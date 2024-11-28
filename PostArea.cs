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
    public partial class PostArea : UserControl
    {
        Post post;
        UserModel users;
        Main p;
        public PostArea(Main parent, Post post)
        {
            InitializeComponent();
            p = parent;
            this.post = post;
            Dock = DockStyle.Top;
            users = new UserModel();

            LoadPost();
            LogoutBtn.Click += (s, e) => p.Logout();
        }

        private async void LoadPost()
        {
            var u = await users.Find(post.UserId);
            if (u != null)
            {
                PostContent.Text = post.Content;
                AuthorBox.Text = u.UserName;
                LikeBtn.Text = $"Like [{post.Likes}]";
                CommentBtn.Text = $"Comment [{post.Comments}]";
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
    }
}
