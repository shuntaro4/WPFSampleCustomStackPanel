using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace CustomStackPanel
{
    public class GroupPanel2 : UserControl
    {
        public static DependencyProperty StyleColorProperty =
            DependencyProperty.Register(
                "StyleColor",
                typeof(Brush),
                typeof(GroupPanel2),
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
                typeof(GroupPanel2),
                new PropertyMetadata(""));

        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set { SetValue(TitleProperty, value); }
        }

        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);

            Border parentBorder = new Border
            {
                BorderBrush = StyleColor,
                BorderThickness = new Thickness(3),
            };

            StackPanel mainStack = new StackPanel();

            Label titleLabel = new Label
            {
                Content = Title,
                Foreground = StyleColor,
            };

            Border lineBorder = new Border
            {
                Margin = new Thickness(5),
                BorderBrush = StyleColor,
                BorderThickness = new Thickness(0, 0, 0, 2)
            };

            StackPanel contentStack = new StackPanel
            {
                Margin = new Thickness(10)
            };

            ContentPresenter contentP = new ContentPresenter
            {
                Content = Content
            };

            contentStack.Children.Add(contentP);

            mainStack.Children.Add(titleLabel);
            mainStack.Children.Add(lineBorder);
            mainStack.Children.Add(contentStack);

            parentBorder.Child = mainStack;

            Content = parentBorder;
        }
    }
}