using Tizen.NUI;
using Tizen.NUI.BaseComponents;
using Tizen.NUI.Components;

namespace NuiExample
{
    public class LinearLayoutCellPaddingExample : ContentPage
    {
        public LinearLayoutCellPaddingExample()
        {
            View linearLayoutView = new View
            {
                Layout = new LinearLayout
                {
                    LinearOrientation = LinearLayout.Orientation.Horizontal,
                    CellPadding = new Size2D(20, 0)
                },
                WidthSpecification = LayoutParamPolicies.MatchParent,
                HeightSpecification = LayoutParamPolicies.MatchParent,
                BackgroundColor = new Color("#D7D6F5FF"),
                Padding = new Extents(40, 40, 40, 40)
            };

            View box1 = new View
            {
                WidthSpecification = LayoutParamPolicies.MatchParent,
                HeightSpecification = LayoutParamPolicies.MatchParent,
                BackgroundColor = new Color("#2B7BAAFF"),
            };

            linearLayoutView.Add(box1);

            View box2 = new View
            {
                WidthSpecification = LayoutParamPolicies.MatchParent,
                HeightSpecification = LayoutParamPolicies.MatchParent,
                BackgroundColor = new Color("#6B7BAAFF"),
            };

            linearLayoutView.Add(box2);

            View box3 = new View
            {
                WidthSpecification = LayoutParamPolicies.MatchParent,
                HeightSpecification = LayoutParamPolicies.MatchParent,
                BackgroundColor = new Color("#AB7BAAFF"),
            };

            linearLayoutView.Add(box3);

            View box4 = new View
            {
                WidthSpecification = LayoutParamPolicies.MatchParent,
                HeightSpecification = LayoutParamPolicies.MatchParent,
                BackgroundColor = new Color("EB7BAAFF"),
            };

            linearLayoutView.Add(box4);

            Content = linearLayoutView;
        }
    }


    class Program : NUIApplication
    {
        protected override void OnCreate()
        {
            base.OnCreate();
            Initialize();
        }

        void Initialize()
        {
            Window.Instance.KeyEvent += OnKeyEvent;
            LinearLayoutCellPaddingExample cellPaddingExample = new LinearLayoutCellPaddingExample();
            Window.Instance.Add(cellPaddingExample);
        }

        public void OnKeyEvent(object sender, Window.KeyEventArgs e)
        {
            if (e.Key.State == Key.StateType.Down && (e.Key.KeyPressedName == "XF86Back" || e.Key.KeyPressedName == "Escape"))
            {
                Exit();
            }
        }

        static void Main(string[] args)
        {
            var app = new Program();
            app.Run(args);
        }
    }
}
