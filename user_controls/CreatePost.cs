using MongoDB.Driver;
using SharpCompress;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSD207_Project_System
{
    public partial class CreatePost : UserControl
    {
        Main p;
        private List<string> Tags = new List<string>();
        private TagModel tags = new TagModel();
        private List<Tag> _tags;
        private PostModel posts = new PostModel();
        public CreatePost(Main p)
        {
            InitializeComponent();
            this.p = p;
            Dock = DockStyle.Fill;
            ContentBox.KeyDown += p.CtrlBackEnable;
            LoadTags();
        }

        private async void LoadTags()
        {
            _tags = await tags.Find(Builders<Tag>.Filter.Empty);
            foreach (var item in _tags)
            {
                var btn = new MaterialSkin.Controls.MaterialButton
                {
                    AutoSizeMode = AutoSizeMode.GrowAndShrink,
                    Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default,
                    Depth = 0,
                    Text = item.Name,
                    Name = item.Name
                };
                btn.Click += (s, e) =>
                {
                    if (btn.UseAccentColor)
                    {
                        Tags.Remove(item.Name);
                        btn.UseAccentColor = false;
                    }
                    else
                    {
                        Tags.Add(item.Name);
                        btn.UseAccentColor = true;
                    }
                };
                TagPanel.Controls.Add(btn);
            }
            TagBox.TextChanged += TagBox_TextChanged;
        }


        private void materialButton1_Click(object sender, EventArgs e)
        {
            p.PrevPage();
        }

        private async void CreatePostBtn_Click(object sender, EventArgs e)
        {
            if (ContentBox.Text.Trim().Length == 0)
            {
                MsgLabel.Text = "Content empty.";
            }
            else
            {
                MsgLabel.Text = "";
                var post = new Post()
                {
                    Content = ContentBox.Text,
                    Tags = Tags,
                    UserId = p.user.Id,
                    Comments = 0,
                    Likes = 0,
                    CreatedAt = DateTime.Now
                };
                var res = await posts.Insert(post);
                if (res)
                {
                    p.NextPage(new Home(p));
                }
            }
        }

        private void TagBox_TextChanged(object sender, EventArgs e)
        {
            if (TagBox.Text.Trim().Length > 0)
            {
                _tags.Where(t => !t.Name.StartsWith(TagBox.Text, StringComparison.OrdinalIgnoreCase)).ForEach(t =>
                {
                    var c = TagPanel.Controls.Find(t.Name, false);
                    if (c.Length > 0)
                    {
                        c.FirstOrDefault().Visible = false;
                    }
                });
            } else
            {
                TagPanel.Controls.Cast<Control>().ForEach(t =>
                {
                    t.Visible = true;
                });
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
