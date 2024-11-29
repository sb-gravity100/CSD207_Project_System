using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CSD207_Project_System
{
    public partial class PostArea : System.Windows.Forms.UserControl
    {
        Post post;
        UserModel users;
        PostModel posts;
        CommentModel comms;
        Main p;
        public PostArea(Main parent, Post post)
        {
            InitializeComponent();
            p = parent;
            this.post = post;
            Dock = DockStyle.Top;
            users = new UserModel();
            posts = new PostModel();

            PostContent.SelectionStart = PostContent.Text.Length;
            PostContent.SelectionLength = 0;
            PostContent.HideSelection = true;
            PostContent.Cursor = Cursors.Arrow;
            PostContent.Font = new Font("Roboto", 24F, FontStyle.Regular, GraphicsUnit.Pixel);
            PostContent.BackColor = SystemColors.ControlLightLight;

            PostContent.GotFocus += (sender, e) => PostContent.Parent.Focus();

            LoadPost();
            LoadComments();
            LogoutBtn.Click += (s, e) => p.Logout();
        }

        private async void LoadPost()
        {
            var u = await users.Find(post.UserId);
            if (u != null)
            {
                PostContent.Text = post.Content;
                AuthorBox.Text = $"— {u.UserName}";
                LikeBtn.Text = $"Like [{post.Likes}]";
                CommentBtn.Text = $"Comment [{post.Comments}]";
                DateBox.Text = post.CreatedAt.ToShortDateString();
            }
        }

        public async void LoadComments()
        {
            CommentPanel.Controls.Clear();
            var c = await posts.GetComments(post.Id);
            CommentBtn.Text = $"Comment [{c.Count}]";
            foreach (var cm in c)
            {
                var comment = await GenerateComment(cm);
                CommentPanel.RowCount++;
                CommentPanel.Controls.Add(comment, 0, CommentPanel.RowCount - 1);
            }
        }

        private void CreatePostBtn_Click(object sender, EventArgs e)
        {
            p.NextPage(new CreatePost(p));
        }

        private void EditProfileBtn_Click(object sender, EventArgs e)
        {
            p.NextPage(new EditProfile(p));
        }

        private void CommentBtn_Click(object sender, EventArgs e)
        {
            var c = new CommentDialog(post, p.user, this);
            c.ShowDialog();
        }

        private async void LikeBtn_Click(object sender, EventArgs e)
        {
            await users.ToggleLikePost(p.user.Id, post.Id);
            var ps = await posts.Find(post.Id);
            post = ps;
            LoadPost();
        }

        private async Task<MaterialCard> GenerateComment(Comment com)
        {
            var u = await users.Find(com.UserId);
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

            var bodyLabel = new MaterialSkin.Controls.MaterialTextBox
            {
                Depth = 0,
                Dock = DockStyle.Top,
                Font = new Font("Roboto", 26F, FontStyle.Regular, GraphicsUnit.Pixel),
                Padding = new Padding(0, 20, 0, 20),
                Text = com.Content,
                AutoSize = false,
                Multiline = true,
                Cursor = Cursors.Arrow,
                ReadOnly = true,
                HideSelection = true,
                SelectionStart = post.Content.Length,
                SelectionLength = 0,
            };
            
            var authorLabel = new MaterialSkin.Controls.MaterialLabel
            {
                Depth = 0,
                Dock = DockStyle.Top,
                Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel),
                Padding = new Padding(0, 20, 0, 20),
                Text = $"{u.UserName} — {p.FormatDate(com.CreatedAt)}",
                AutoSize = false,
            };

            return postsCard;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            p.PrevPage();
        }
    }
}
