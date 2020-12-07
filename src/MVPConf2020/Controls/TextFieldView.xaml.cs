using System;
using Xamarin.Forms;

namespace MVPConf2020.Controls
{
    public partial class TextFieldView : ContentView
    {
        public TextFieldView()
        {
            InitializeComponent();
        }

        public static readonly BindableProperty TitleProperty =
            BindableProperty.Create(
                nameof(Title),
                typeof(string),
                typeof(TextFieldView),
                string.Empty,
                propertyChanged: TitleChanged);

        public static readonly BindableProperty RequiredProperty =
            BindableProperty.Create(
                nameof(Required),
                typeof(bool),
                typeof(TextFieldView),
                true,
                propertyChanged: RequiredChanged);

        public static readonly BindableProperty PlaceHolderProperty =
            BindableProperty.Create(
                nameof(PlaceHolder),
                typeof(string),
                typeof(TextFieldView),
                null,
                propertyChanged: PlaceHolderChanged);

        public string Title
        {
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty, value);
        }

        public bool Required
        {
            get => (bool)GetValue(RequiredProperty);
            set => SetValue(RequiredProperty, value);
        }

        public string PlaceHolder
        {
            get => (string)GetValue(PlaceHolderProperty);
            set => SetValue(PlaceHolderProperty, value);
        }

        private static void TitleChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is TextFieldView field)
            {
                field.LblTitle.Text = (newValue is null) ? string.Empty : newValue.ToString();
            }
        }

        private static void RequiredChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is TextFieldView field)
            {
                field.LblRequired.IsVisible = (bool)newValue;
            }
        }

        private static void PlaceHolderChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is TextFieldView field)
            {
                field.TxtText.Placeholder = (newValue is null) ? string.Empty : newValue.ToString();
            }
        }
    }
}
