namespace AndroidApp
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            Console.WriteLine ($"String ID: {Resource.String.library_name}");
            Console.WriteLine ($"String Value: {Resources?.GetString(Resource.String.library_name)}");
        }
    }
}