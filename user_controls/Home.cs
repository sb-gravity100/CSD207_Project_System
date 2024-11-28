using MongoDB.Driver;
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
    public partial class Home : UserControl
    {
        private static readonly List<string> TAG_CONSTANT = new List<string>();
        Main p;
        PostModel posts;
        UserModel users;
        public Home(Main parent)
        {
            InitializeComponent();
            p = parent;
            Dock = DockStyle.Top;
            Size = p.Size;
            posts = new PostModel();
            users = new UserModel();
            ProfileInit();
        }

        private void ProfileInit()
        {
            DisplayNameLabel.Text = p.user.DisplayName;
            UsernameLabel.Text = p.user.UserName;
            LoadPosts();
        }

        private async void LoadPosts()
        {
            try
            {
                var p = await posts.Find(Builders<Post>.Filter.Empty);
                foreach (var post in p)
                {
                    var u = await users.Find(post.UserId);
                    if (u != null)
                    {
                        var postcard = CreatePostsCard(post, u);
                        PostsPanel.RowCount++;
                        PostsPanel.Controls.Add(postcard, 0, PostsPanel.RowCount - 1);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void CreatePostBtn_Click(object sender, EventArgs e)
        {
            p.NextPage(new CreatePost(p));
        }

        private MaterialSkin.Controls.MaterialCard CreatePostsCard(Post post, User user)
        {
            var postsCard = new MaterialSkin.Controls.MaterialCard
            {
                BackColor = System.Drawing.Color.FromArgb(255, 255, 255),
                Depth = 0,
                ForeColor = System.Drawing.Color.FromArgb(222, 0, 0, 0),
                Padding = new Padding(14),
                Margin = new Padding(14),
                Dock = DockStyle.Top,
                MinimumSize = new Size(0, 200)
            };

            var bodyLabel = new MaterialSkin.Controls.MaterialLabel
            {
                Depth = 0,
                Dock = DockStyle.Fill,
                Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel),
                Padding = new Padding(0, 20, 0, 20),
                Text = post.Content,
                AutoSize = false,
                Size = new Size(362, 100)
            };

            var subtitleLabel = new MaterialSkin.Controls.MaterialLabel
            {
                Depth = 0,
                Dock = DockStyle.Bottom,
                Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel),
                FontType = MaterialSkin.MaterialSkinManager.fontType.Caption,
                Text = $"{user.UserName} — {FormatDate(post.CreatedAt)}",
                Size = new Size(362, 14),
            };

            var tagPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Bottom,
                FlowDirection = FlowDirection.BottomUp,
                Size = new Size(362, 38),
            };

            foreach (var tag in post.Tags)
            {
                var tagButton = new MaterialSkin.Controls.MaterialButton
                {
                    AutoSizeMode = AutoSizeMode.GrowAndShrink,
                    Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default,
                    Depth = 0,
                    HighEmphasis = true,
                    Text = tag,
                    Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined,
                    UseAccentColor = true,
                    Margin = new Padding(0, 0, 5, 0),
                };
                tagPanel.Controls.Add(tagButton);
            }

            var actionPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Bottom,
                FlowDirection = FlowDirection.LeftToRight,
                Size = new Size(362, 43),
                Padding = new Padding(0, 5, 0, 0),
            };

            var likeButton = new MaterialSkin.Controls.MaterialButton
            {
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default,
                Depth = 0,
                HighEmphasis = true,
                Text = $"Like [{post.Likes}]",
                UseAccentColor = true,
                Margin = new Padding(0, 0, 5, 0),
            };

            var commentButton = new MaterialSkin.Controls.MaterialButton
            {
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default,
                Depth = 0,
                HighEmphasis = true,
                Text = $"Comment [{post.Comments}]",
                UseAccentColor = true,
                Margin = new Padding(0, 0, 5, 0),
            }

            actionPanel.Controls.Add(likeButton);
            actionPanel.Controls.Add(commentButton);

            postsCard.Controls.Add(tagPanel);
            postsCard.Controls.Add(bodyLabel);
            postsCard.Controls.Add(subtitleLabel);
            postsCard.Controls.Add(actionPanel);
            postsCard.Controls.SetChildIndex(subtitleLabel, 0);

            return postsCard;
        }


        private string FormatDate(DateTime dateTime)
        {
            TimeSpan timeSpan = DateTime.Now - dateTime;

            if (timeSpan.TotalSeconds < 60)
                return $"{(int)timeSpan.TotalSeconds} seconds ago";
            if (timeSpan.TotalMinutes < 60)
                return $"{(int)timeSpan.TotalMinutes} minutes ago";
            if (timeSpan.TotalHours < 24)
                return $"{(int)timeSpan.TotalHours} hours ago";
            if (timeSpan.TotalDays < 7)
                return $"{(int)timeSpan.TotalDays} days ago";
            if (timeSpan.TotalDays < 30)
                return $"{(int)(timeSpan.TotalDays / 7)} weeks ago";

            return dateTime.ToString("MMMM dd, yyyy");
        }

    }
}
