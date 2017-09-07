using System.Collections.Generic;

using Android.App;
using Android.OS;
using Android.Widget;
using Android.Support.V7.App;

namespace Cardif
{
    [Activity(Label = "Exam", MainLauncher = false, Icon = "@drawable/icon", Theme = "@style/Theme2")]
    public class Exam : AppCompatActivity
    {

        ExpandableListViewAdapter mAdapter;
        ExpandableListView expandableListView;
        List<string> group = new List<string>();
        Dictionary<string, List<string>> dicMyMap = new Dictionary<string, List<string>>();


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            //set our view from the"ExpandableListView" layout Resource
            SetContentView(Resource.Layout.ExpandableListView);
            var toolbar2 = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar2);
            SetSupportActionBar(toolbar2);
            SupportActionBar.Title = "Past Papers";

            expandableListView = FindViewById<ExpandableListView>(Resource.Id.expandableList);

            //set data
            SetData(out mAdapter);
            expandableListView.SetAdapter(mAdapter);

            expandableListView.ChildClick += (s, e) =>
            {
                Toast.MakeText(this, "" + mAdapter.GetChild(e.GroupPosition, e.ChildPosition), ToastLength.Short).Show();
            };
        }

        private void SetData(out ExpandableListViewAdapter mAdapter)
        {
            List<string> Year2013 = new List<string>();
            Year2013.Add("Calculus");
            Year2013.Add("Applied Maths");
            Year2013.Add("Circuit & Network Theory");
            Year2013.Add("Computer Programming I");
            Year2013.Add("Principles of Marketing");
            Year2013.Add("Electrical Measurement");
            Year2013.Add("Physical Electronics");
            Year2013.Add("Mechanics of Machines");

            List<string> Year2014 = new List<string>();
            Year2014.Add("Calculus");
            Year2014.Add("Applied Maths");
            Year2014.Add("Circuit & Network Theory");
            Year2014.Add("Computer Programming I");
            Year2014.Add("Principles of Marketing");
            Year2014.Add("Electrical Measurement");
            Year2014.Add("Physical Electronics");
            Year2014.Add("Mechanics of Machines");
            
            List<string> Year2015 = new List<string>();
            Year2015.Add("Calculus");
            Year2015.Add("Applied Maths");
            Year2015.Add("Circuit & Network Theory");
            Year2015.Add("Computer Programming I");
            Year2015.Add("Principles of Marketing");
            Year2015.Add("Electrical Measurement");
            Year2015.Add("Physical Electronics");
            Year2015.Add("Mechanics of Machines");

            List<string> Year2016 = new List<string>();
            Year2016.Add("Calculus");
            Year2016.Add("Applied Maths");
            Year2016.Add("Circuit & Network Theory");
            Year2016.Add("Computer Programming I");
            Year2016.Add("Principles of Marketing");
            Year2016.Add("Electrical Measurement");
            Year2016.Add("Physical Electronics");
            Year2016.Add("Mechanics of Machines");



            group.Add("Year2013 Materials");
            group.Add("Year2014 Materials");
            group.Add("Year2015 Materials");
            group.Add("Year2016 Materials");

            dicMyMap.Add(group[0], Year2013);
            dicMyMap.Add(group[1], Year2014);
            dicMyMap.Add(group[2], Year2015);
            dicMyMap.Add(group[3], Year2016);


            mAdapter = new ExpandableListViewAdapter(this, group, dicMyMap);

        }
    }
}