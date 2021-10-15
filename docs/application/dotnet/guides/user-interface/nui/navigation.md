<style>
    .tabcontent img {
        border: 1px solid #555;
        max-width: 100% !important;
        max-height: 100%;
    }
</style>

# Navigation

Navigation ensure that the users can interact forward, backward or across with application . The main reason why there is a strong emphasis of navigation is the fact the created user experience is the main part of the getting success on the market. The following guide shows how to use it correctly components already implemented in NUI.

## Navigator

The main component that enables navigation mechanisms is Navigator. The `Navigator` class allows you to navigate the user interface by using the stack (LIFO) mechanism. The `Navigator` itself provides methods that can push or pop the views on the top of stack and also insert the views.

## Default navigator



### Windows default navigator

The following code shows how to get default Navigator from the Window.

```csharp
class Program : NUIApplication
{
    protected override void OnCreate()
    {
        base.OnCreate();
        Initialize();
    }

    void Initialize()
    {
        Navigator navigator;
        navigator = Window.Instance.GetDefaultNavigator();
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
```

### Page Navigator

The following code shows how to get default Navigator from the Window.

```csharp
class Program : NUIApplication
{
    protected override void OnCreate()
    {
        base.OnCreate();
        Initialize();
    }

    void Initialize()
    {
        Navigator navigator;
        navigator = Window.Instance.GetDefaultNavigator();
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
```

## Modifying stack

### Push

```csharp
ContentPage firstPage = new ContentPage();
Navigator navigator = page.Navigator;
navigator.Push(new ContentPage());
```

### Pop page from the stack

<!-- TODO: add example image with push -->

```csharp
ContentPage firstPage = new ContentPage();
Navigator navigator = page.Navigator;
navigator.Pop();
```

### Remove

The handle the stack of view's the navigator class implements the methods Push and Pop.

## ContentPage

To handle navigation properly the NUI framework introduced the `ContentPage` class. The `ContentPage` itself provides many features to improve handle properly the user interface.

| Property               | Type            | Description  |
| -----------------------| --------------- | ------------ |
| `AppBar`            | AppBar   | AppBar is added as a child of ContentPage automatically. AppBar is positioned at the top of the Page. |
| `Content`        | View |  Content of ContentPage. Content is added as a child of ContentPage automatically. Content is positioned below AppBar. Content is resized to fill the full screen except AppBar. |

### AppBar

The AppBar has a important feature that improves navigation. By default its implements the back button that aromaticity calls the `Pop` from the Navigator.

<div id="TabSection1">
    <div class="sampletab " id="ProjectCreateTab">
        <button id="ContentPage-Example-AppBar-CSharp" class="tablinks " onclick="openTabSection(event, 'ContentPage-Example-AppBar-CSharp', 'TabSection1') ">C#</button>
        <button id="ContentPage-Example-AppBar-Xaml" class="tablinks " onclick="openTabSection(event, 'ContentPage-Example-AppBar-Xaml', 'TabSection1') ">Xaml</button>
    </div>
    <div id="ContentPage-Example-AppBar-CSharp" class="tabcontent">
        <table>
            <tbody>
                <tr>
<span style="display:block">


```csharp
ContentPage page = new ContentPage();
page.AppBar = new AppBar
{
    Title = "Title of AppBar"
};
```

</span>
                </tr>
            </tbody>
        </table>
    </div>
    <div id="ContentPage-Example-AppBar-Xaml" class="tabcontent">
        <table>
            <tbody>
                <tr>
<span style="display:block">

```xaml
<ContentPage.AppBar>
    <AppBar Title="Title of AppBar">
</ContentPage.AppBar>
```

</span>
                </tr>
            </tbody>
        </table>
    </div>
</div>

## Related Information

- Dependencies
  - Tizen 6.5 and Higher

<script>
    function openTabSection(evt, profileName, sectionId) {
        var i, tabcontent, tablinks, section;
        let selected = 0;

        section = document.getElementById(sectionId);
        tabcontent = section.getElementsByClassName("tabcontent");
        for (i = 0; i < tabcontent.length; i++) {
            tabcontent[i].style.display = "none";
            if (tabcontent[i].id == profileName) {
                selected = i;
            }
        }

        tablinks = section.getElementsByClassName("tablinks");

        for (i = 0; i < tablinks.length; i++) {
            tablinks[i].className = tablinks[i].className.replace(" active", "");
        }

        tabcontent[selected].style.display = "block";
        evt.currentTarget.className += " active";
    }
    document.getElementById("ContentPage-Example-AppBar-CSharp").click();
</script>