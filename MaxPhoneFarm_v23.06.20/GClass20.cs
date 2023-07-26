using System.Windows.Forms;

public class GClass20 : TreeView
{
	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = base.CreateParams;
			createParams.Style |= 128;
			return createParams;
		}
	}
}
