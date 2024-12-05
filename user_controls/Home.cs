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
        Main p;
        PostModel posts;
        UserModel users;
        public Home(Main parent)
        {
            InitializeComponent();
            p = parent;
            Dock = DockStyle.Top;
            posts = new PostModel();
            users = new UserModel();
            ProfileInit();

            

            LogoutBtn.Click += (s, e) => p.Logout();
            TagPostFilter.ControlAdded += (s, e) => Task.Run(LoadPosts);
            TagPostFilter.ControlRemoved += (s, e) => Task.Run(LoadPosts);
        }

        private void ProfileInit()
        {
            DisplayNameLabel.Text = p.user.DisplayName;
            UsernameLabel.Text = p.user.UserName;
            Task.Run(LoadPosts);
        }

        private async Task LoadPosts()
        {
            PostsPanel.Controls.Clear();
            try
            {
                var filter = Builders<Post>.Filter.Empty;
                if (TagPostFilter.Controls.Count > 0)
                {
                    Console.WriteLine("Not empty.");
                    var st = new List<string>();
                    foreach (Control ct in TagPostFilter.Controls)
                    {
                        st.Add(ct.Text);
                    }
                    filter = Builders<Post>.Filter.AnyIn(post => post.Tags, st);
                }
                var p = await posts.Find(filter);
                foreach (var post in p)
                {
                    var u = await users.Find(post.UserId);
                    if (u != null)
                    {
                        Invoke(new Action(() =>
                        {
                            var postcard = CreatePostsCard(post, u);
                            PostsPanel.RowCount++;
                            PostsPanel.Controls.Add(postcard, 0, PostsPanel.RowCount - 1);
                        }));
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
                MinimumSize = new Size(0, 300)
            };

            var bodyLabel = new MaterialSkin.Controls.MaterialMultiLineTextBox
            {
                Depth = 0,
                Dock = DockStyle.Fill,
                Font = new Font("Roboto", 24F, FontStyle.Regular, GraphicsUnit.Pixel),
                Padding = new Padding(0, 20, 0, 20),
                Text = post.Content,
                AutoSize = false,
                Size = new Size(362, 0),
                Cursor = Cursors.Hand,
                ReadOnly = true,
                HideSelection = true,
                SelectionStart = post.Content.Length,
                SelectionLength = 0,
            };

            bodyLabel.GotFocus += (sender, e) => bodyLabel.Parent.Focus();

            bodyLabel.Click += (s, e) =>
            {
                p.NextPage(new PostArea(p, post));
            };

            bodyLabel.MouseHover += (s, e) =>
            {
                //bodyLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            };

            bodyLabel.MouseLeave += (s, e) =>
            {
                //bodyLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.Body1;
            };

            var subtitleLabel = new MaterialSkin.Controls.MaterialLabel
            {
                Depth = 0,
                Dock = DockStyle.Bottom,
                Font = new Font("Roboto", 12F, FontStyle.Regular, GraphicsUnit.Pixel),
                FontType = MaterialSkin.MaterialSkinManager.fontType.Caption,
                Text = $"{user.UserName} — {p.FormatDate(post.CreatedAt)}",
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
                    Text = tag,
                    Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined,
                    UseAccentColor = false,
                    Margin = new Padding(0, 0, 5, 0),
                };

                tagButton.Click += (s, e) =>
                {
                    var tb = new MaterialSkin.Controls.MaterialButton
                    {
                        AutoSizeMode = AutoSizeMode.GrowAndShrink,
                        Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default,
                        Depth = 0,
                        Text = tag,
                        Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined,
                        UseAccentColor = true,
                        Margin = new Padding(0, 0, 5, 0),
                    };
                    tb.Click += (ss, ee) =>
                    {
                        TagPostFilter.Controls.Remove(tb);
                    };
                    TagPostFilter.Controls.Add(tb);
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

            likeButton.Click += async (s, e) =>
            {
                await users.ToggleLikePost(p.user.Id, post.Id);
                var ps = await posts.Find(post.Id);
                post = ps;
                Invoke(new Action(() =>
                {
                    likeButton.Text = $"Like [{ps.Likes}]";
                }));
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
            };

            actionPanel.Controls.Add(likeButton);
            actionPanel.Controls.Add(commentButton);

            postsCard.Controls.Add(tagPanel);
            postsCard.Controls.Add(bodyLabel);
            postsCard.Controls.Add(subtitleLabel);
            postsCard.Controls.Add(actionPanel);
            postsCard.Controls.SetChildIndex(subtitleLabel, 0);

            return postsCard;
        }



        private void EditProfileBtn_Click(object sender, EventArgs e)
        {
            p.NextPage(new EditProfile(p));
        }
    }
}
