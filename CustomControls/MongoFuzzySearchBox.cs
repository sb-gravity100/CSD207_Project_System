using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSD207_Project_System.CustomControls
{
    using MongoDB.Driver;
    using MongoDB.Bson;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class MongoUserSearchBox : TextBox
    {
        private ListBox SuggestionBox;
        private IMongoCollection<User> Collection;
        private Dictionary<string, Func<User, string>> Selectors;
        private List<string> SearchFields;

        public MongoUserSearchBox()
        {
            SuggestionBox = new ListBox
            {
                Visible = false,
                Width = this.Width,
                BackColor = Color.White,
                ForeColor = Color.Black,
                BorderStyle = BorderStyle.FixedSingle,
                Font = new Font("Segoe UI", 10),
                ItemHeight = 25
            };

            this.BorderStyle = BorderStyle.FixedSingle;
            this.Font = new Font("Segoe UI", 10);
            this.ForeColor = Color.Black;

            this.ParentChanged += (s, e) =>
            {
                if (this.Parent != null)
                {
                    SuggestionBox.Parent = this.Parent;
                    SuggestionBox.BringToFront();
                }
            };

            SuggestionBox.Click += (s, e) =>
            {
                if (SuggestionBox.SelectedItem != null)
                {
                    this.Text = SuggestionBox.SelectedItem.ToString();
                    SuggestionBox.Visible = false;
                }
            };

            this.TextChanged += (s, e) => UpdateSuggestionsAsync();
            this.LostFocus += (s, e) =>
            {
                if (!SuggestionBox.Focused)
                    SuggestionBox.Visible = false;
            };

            SuggestionBox.MouseLeave += (s, e) => SuggestionBox.Visible = false;
        }

        public void InitializeMongo(IMongoCollection<User> collection, List<string> searchFields, Dictionary<string, Func<User, string>> selectors)
        {
            Collection = collection;
            Selectors = selectors;
            SearchFields = searchFields;
        }

        private async void UpdateSuggestionsAsync()
        {
            if (string.IsNullOrEmpty(this.Text) || Collection == null || Selectors == null || SearchFields == null || !SearchFields.Any())
            {
                SuggestionBox.Visible = false;
                return;
            }

            try
            {
                // Prepare the search term
                var searchTerm = this.Text.ToLower();

                // Define the aggregation pipeline
                var pipeline = new List<BsonDocument>
        {
            new BsonDocument
            {
                {
                    "$search", new BsonDocument
                    {
                        {
                            "compound", new BsonDocument
                            {
                                {
                                    "should", new BsonArray(
                                        SearchFields.Select(field => new BsonDocument
                                        {
                                            {
                                                "text", new BsonDocument
                                                {
                                                    { "query", searchTerm },
                                                    { "path", field },
                                                    {
                                                        "fuzzy", new BsonDocument
                                                        {
                                                            { "maxEdits", 2 },   // Max Levenshtein distance (default is 2)
                                                            { "prefixLength", 2 } // Characters at the start to ignore for fuzzy match
                                                        }
                                                    }
                                                }
                                            }
                                        }).ToArray()
                                    )
                                }
                            }
                        }
                    }
                }
            },
            new BsonDocument
            {
                { "$limit", 10 }  // Limit the results to the top 10 matches
            }
        };

                // Perform the aggregation query
                var aggregateResults = await Collection.Aggregate<User>(pipeline).ToListAsync();

                var Suggestions = aggregateResults.Select(result =>
                {
                    // Extract the field value (assuming Selectors is set up)
                    return SearchFields.Select(field => Selectors[field](result)).FirstOrDefault();
                }).ToList();

                if (Suggestions.Count > 0)
                {
                    SuggestionBox.Items.Clear();
                    SuggestionBox.Items.AddRange(Suggestions.ToArray());
                    SuggestionBox.Location = this.Parent.PointToClient(this.PointToScreen(new Point(0, this.Height)));
                    SuggestionBox.Width = this.Width;
                    SuggestionBox.Height = Math.Min(150, Suggestions.Count * SuggestionBox.ItemHeight);
                    SuggestionBox.Visible = true;
                }
                else
                {
                    SuggestionBox.Visible = false;
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine($"Error Fetching Suggestions: {Ex.Message}");
            }
        }



    }

}
