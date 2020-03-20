using System;
using System.Collections.Generic;
using System.Text;

namespace Homework6
{
    class PageDataViewModel
    {
        public PageDataViewModel(Type type, string title, string description)
        {
            Type = type;
            Title = title;
            Description = description;
        }

        public Type Type { private set; get; }

        public string Title { private set; get; }

        public string Description { private set; get; }

        static PageDataViewModel()
        {
            All = new List<PageDataViewModel>
            {
              
                new PageDataViewModel(typeof(Scroll), "Scroll",
                                      "Exciting scrolling content"),

                new PageDataViewModel(typeof(ContentView), "Content View",
                                      "See how exciting the content view layout is"),

                new PageDataViewModel(typeof(StackLayout), "StackLayout",
                                      "Very cool stack layout content"),
              
                new PageDataViewModel(typeof(SharedResources), "Shared Resources",
                                      "Shared Resources"),
                

            };
        }

        public static IList<PageDataViewModel> All { private set; get; }
    }
}
