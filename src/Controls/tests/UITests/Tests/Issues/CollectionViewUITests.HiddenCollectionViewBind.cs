using NUnit.Framework;
using UITest.Appium;
using UITest.Core;

namespace Microsoft.Maui.AppiumTests.Issues
{
	public class HiddenCollectionViewBindUITests : _IssuesUITest
	{
		const string Success = "Success";

		public HiddenCollectionViewBindUITests(TestDevice device)
			: base(device)
		{
		}

		public override string Issue => "[Bug] [iOS] CollectionView does not bind to items if `IsVisible=False`";

		// CollectionShouldInvalidateOnVisibilityChange (src\Compatibility\ControlGallery\src\Issues.Shared\Issue13203.cs)
		[Test]
		[FailsOnIOS("This test is failing, requires research.")]
		[FailsOnMac("This test is failing, requires research.")]
		[FailsOnWindows]
		public void CollectionShouldInvalidateOnVisibilityChange()
		{
			if (Device == TestDevice.Android)
			{
				App.WaitForNoElement(Success);
			}
			else
			{
				Assert.Ignore("This test is failing, requires research.");
			}
		}
	}
}