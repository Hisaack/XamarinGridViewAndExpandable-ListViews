using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Views;

namespace Cardif
{
    [Activity(Label = "Cardif", MainLauncher = true, Icon = "@drawable/icon", Theme ="@style/MyTheme")]
    public class MainActivity : AppCompatActivity
    {
        GridView gridview;
        string[] gridViewString =
        {
            "Applied Mathematics", "Calculus III", "Circuit & NetWork Theory",
                "Electrical Measurement", "Mechanics Of Machines", "Physical Electronics",
                "Principles Of Marketing", "Computer Programming I", "Exam"
        };
        int[] imageId =
        {
            Resource.Drawable.appmat, Resource.Drawable.calculus, Resource.Drawable.cnt,
            Resource.Drawable.elecm, Resource.Drawable.mech, Resource.Drawable.phyc,
            Resource.Drawable.pom, Resource.Drawable.programming, Resource.Drawable.exam
        };
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
            Android.Support.V7.Widget.Toolbar toolbar1 = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar1);
            SetSupportActionBar(toolbar1);
            SupportActionBar.Title = "EEE Plus";

            CustomGridViewAdapter adapter= new CustomGridViewAdapter(this, gridViewString, imageId);
            gridview = FindViewById<GridView>(Resource.Id.gridView);
            gridview.Adapter = adapter;

            gridview.ItemClick += delegate (object sender, AdapterView.ItemClickEventArgs args)
            {
                switch (args.Position)
                {
                    case 0:
                        StartActivity(typeof(AppliedMaths));
                        break;

                    case 1:
                        StartActivity(typeof(Calculus));
                        break;

                    case 2:
                        StartActivity(typeof(cnt));
                        break;
                    case 3:
                        StartActivity(typeof(ElectricalMeasurement));
                        break;
                    case 4:
                        StartActivity(typeof(Mechanics));
                        break;
                    case 5:
                        StartActivity(typeof(PhysicalElectronics));
                        break;
                    case 6:
                        StartActivity(typeof(PrinciplesOfMarketing));
                        break;
                    case 7:
                        StartActivity(typeof(Programming));
                        break;
                    case 8:
                        StartActivity(typeof(Exam));
                        break;
                }
            };
        }
  

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            var inflater = MenuInflater;
            inflater.Inflate(Resource.Menu.toolbarMenu, menu);
            return true;
        }
        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.about)
            {
                Toast.MakeText(this, "About", ToastLength.Short).Show();
            }
            else if (id == Resource.Id.bookmark)
            {
                Toast.MakeText(this, "Bookmark", ToastLength.Short).Show();
            }
            else if (id == Resource.Id.rate)
            {
                Toast.MakeText(this, "Rate App", ToastLength.Short).Show();
            }
            else if (id == Resource.Id.share)
            {
                Toast.MakeText(this, "Share", ToastLength.Short).Show();
            }
            else if (id == Resource.Id.feedback)
            {
                Toast.MakeText(this, "Feedback", ToastLength.Short).Show();
            }
            return true;
        }

    }
}

