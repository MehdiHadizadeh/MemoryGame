using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MemoryGame
{
    class Board
    {
        public PictureBox PictureBox { get; set; }
        private int Size { get; set; }
        public bool IsActive { get; set; }

    }
}
