using Tizen.NUI;
using Tizen.NUI.BaseComponents;
using Tizen.NUI.Components;

namespace NuiExample
{
    public class LinearLayoutAlignmentExample : ContentPage
    {
        public LinearLayoutAlignmentExample()
        {
            WidthSpecification = LayoutParamPolicies.MatchParent;
            HeightSpecification = LayoutParamPolicies.MatchParent;

            View linearLayoutView = new View
            {
                Layout = new LinearLayout
                {
                    LinearAlignment = LinearLayout.Alignment.Center,
                    LinearOrientation = LinearLayout.Orientation.Horizontal
                },
                WidthSpecification = LayoutParamPolicies.MatchParent,
                HeightSpecification = LayoutParamPolicies.MatchParent,
                BackgroundColor = new Color("#D7D6F5FF"),
                Padding = new Extents(40, 40, 40, 40)
            };

            View box1 = new View
            {
                WidthSpecification = 300,
                HeightSpecification = 300,
                BackgroundColor = new Color("#2B7BAAFF")
            };

            linearLayoutView.Add(box1);

            View box2 = new View
            {
                WidthSpecification = 300,
                HeightSpecification = 300,
                BackgroundColor = new Color("#6B7BAAFF")
            };

            linearLayoutView.Add(box2);

            View box3 = new View
            {
                WidthSpecification = 300,
                HeightSpecification = 300,
                BackgroundColor = new Color("#AB7BAAFF")
            };

            linearLayoutView.Add(box3);

            Add(linearLayoutView);
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
            LinearLayoutAlignmentExample alignmentExample = new LinearLayoutAlignmentExample();
            Window.Instance.Add(alignmentExample);
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
