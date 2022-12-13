using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaloWorkshopManager
{
    public partial class PictureForm : Form
    {
        public PictureForm(Image image, string title)
        {
            InitializeComponent();
            Text = title;
            picture.Image = image;
            Size = image.Size;
            picture.Size = image.Size;
        }
    }
}
