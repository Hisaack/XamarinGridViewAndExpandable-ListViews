using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Support.V7.App;

namespace Cardif
{
    [Activity(Label = "Mechanics Of Machines", MainLauncher = false, Icon = "@drawable/icon", Theme = "@style/Theme2")]
    public class Mechanics : AppCompatActivity
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
            SupportActionBar.Title = "Mecahanics of Machines";

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
            List<string> Offline = new List<string>();
            Offline.Add("Notes");
            Offline.Add("References");
            Offline.Add("Revision Materials");

            List<string> Online = new List<string>();
            Online.Add("Notes");
            Online.Add("School Portal");
            Online.Add("References");

            List<string> Youtube = new List<string>();
            Youtube.Add("Playlists");
            Youtube.Add("Videos");
            Youtube.Add("Channels");

            group.Add("Offline Materials");
            group.Add("Online Materials");
            group.Add("Youtube References");

            dicMyMap.Add(group[0], Offline);
            dicMyMap.Add(group[1], Online);
            dicMyMap.Add(group[2], Youtube);

            mAdapter = new ExpandableListViewAdapter(this, group, dicMyMap);

        }
    }
}