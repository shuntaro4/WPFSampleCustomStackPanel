using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace CustomStackPanel
{
    /// <summary>
    /// GroupPanel.xaml の相互作用ロジック
    /// </summary>
    public partial class GroupPanel : UserControl
    {
        public static DependencyProperty StyleColorProperty =
            DependencyProperty.Register(
                "StyleColor",
                typeof(Brush),
                typeof(GroupPanel),
                new PropertyMetadata(new SolidColorBrush(Colors.Transparent)));

        public Brush StyleColor
        {
            get => (Brush)GetValue(StyleColorProperty);
            set { SetValue(StyleColorProperty, value); }
        }

        public static DependencyProperty TitleProperty =
            DependencyProperty.Register(
                "Title",
                typeof(string),
                typeof(GroupPanel),
                new PropertyMetadata(""));

        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set { SetValue(TitleProperty, value); }
        }

        public GroupPanel()
        {
            InitializeComponent();
        }
    }
}