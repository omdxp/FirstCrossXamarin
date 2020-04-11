using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace FirstCrossXamarin.Models
{
    public class MasterMenuItem
    {
        public string Title { get; set; }
        public string IconSource { get; set; }
        public Color BackgroundColor { get; set; }
        public Type TargetType { get; set; }

        public MasterMenuItem(string Title, string IconSource, Color BackgroundColor, Type TargetType)
        {
            this.Title = Title;
            this.IconSource = IconSource;
            this.BackgroundColor = BackgroundColor;
            this.TargetType = TargetType;
        }
    }
}
