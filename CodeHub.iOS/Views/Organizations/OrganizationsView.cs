using CodeFramework.ViewControllers;
using CodeHub.Core.ViewModels.Organizations;
using MonoTouch.Dialog;
using CodeFramework.iOS.Elements;

namespace CodeHub.iOS.Views.Organizations
{
    public class OrganizationsView : ViewModelCollectionDrivenViewController
	{
        public override void ViewDidLoad()
        {
            Title = "Organizations".t();
            NoItemsText = "No Organizations".t();

            base.ViewDidLoad();

            var vm = (OrganizationsViewModel) ViewModel;
			BindCollection(vm.Organizations, x =>
			{
				var e = new UserElement(x.Login, string.Empty, string.Empty, x.AvatarUrl);
				e.Tapped += () => vm.GoToOrganizationCommand.Execute(x);
				return e;
			});
        }
	}
}

