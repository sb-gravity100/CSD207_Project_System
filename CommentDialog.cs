using MaterialSkin;
using MaterialSkin.Controls;
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
    public partial class CommentDialog : MaterialForm
    {
        private Post post;
        private User user;
        private PostArea postarea;
        private CommentModel comments;
        public MaterialSkinManager skin = MaterialSkinManager.Instance;

        public CommentDialog(Post p, User u, PostArea pa)
        {
            InitializeComponent();
            post = p;
            user = u;
            postarea = pa;

            skin.AddFormToManage(this);
        }

        private async void materialButton1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(CommentBox.Text))
            {
                var c = new Comment()
                {
                    Content = CommentBox.Text,
                    CreatedAt = DateTime.Now,
                    Likes = 0,
                    PostId = post.Id,
                    UserId = user.Id,
                };

                var res = await comments.Insert(c);

                if (res)
                {
                    this.Close();
                    postarea.LoadComments();
                }
            }
        }

        private void CommentDialog_Load(object sender, EventArgs e)
        {

        }

        private void CommentBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
