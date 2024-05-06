using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Shatterpoint.Maui.Services
{

    public class NavigationChangedEventArgs
    {
        public int SelectedTab { get; set; }
        public bool Modal { get; set; } = false;
    }

    /// <summary>
    /// Ctor
    /// </summary>
    /// <param name="navigationManager"></param>
    public class NavigationService
    {
        public event EventHandler<NavigationChangedEventArgs> NavigationChanged;
        public static List<string> NavigationStack { get; set; } = [];

        protected NavigationManager NavigationManager { get; }

        public NavigationService(NavigationManager navigationManager)
        {
            NavigationManager = navigationManager;
        }

        public void NavigateFromTo(string from, string to)
        {
            NavigationManager.NavigateTo(to);
            if (!string.IsNullOrWhiteSpace(from))
                NavigationStack.Add(from);

            NavigationChanged.Invoke(this, new NavigationChangedEventArgs()
            {
                SelectedTab = GetSelectionTab(to),
                Modal = IsModal(to)
            });
        }

        public void Back()
        {
            // No back if not history
            if (NavigationStack.Count == 0)
                return;

            var backDestination = NavigationStack.Last();
            NavigationStack.RemoveAt(NavigationStack.Count - 1);
            NavigationManager.NavigateTo(backDestination);

            NavigationChanged.Invoke(this, new NavigationChangedEventArgs()
            {
                SelectedTab = GetSelectionTab(backDestination),
                Modal = IsModal(backDestination)
            });
        }

        private int GetSelectionTab(string url)
        {
            if (url == "/")
                return 1;
            if (url.Contains("build"))
                return 1;
            if (url.Contains("play"))
                return 2;
            if (url.Contains("sandbox"))
                return 3;

            return -1;
        }

        private bool IsModal(string url)
        {
            if (url.Contains("cards"))
                return true;
            return false;
        }
    }
}
