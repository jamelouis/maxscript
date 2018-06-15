using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

/// The name of the namespace we want our
/// demo to exist in.
namespace MaxScriptIntegrationDemo
{
	/// <summary>
	/// A simple control used to illustrate integration between .Net and MaxScript.
	/// The control contains a "Create Circle" button and a "Create Omni Light" 
	/// button. The buttons have event associated with them which can be
	/// registered for by MaxScript. Be sure that all objects that
	/// need to communicate with MaxScript inherit directly or indirectly from
	/// System.ComponentModel.Component or events won't work correctly.
	/// </summary>
	public partial class MaxScriptIntegrationDemoControl : UserControl
	{
		public MaxScriptIntegrationDemoControl()
		{
			InitializeComponent();
			_colorDlg = new ColorDialog();
		}

		/// <summary>
		/// The CreateCircle event can be registered for by MaxScript so that when
		/// the event is raised MaxScript can take the appropriate action.
		/// </summary>
		public static event EventHandler CreateCircle;

		/// <summary>
		/// This event will be called when the "Create Circle" button is clicked on the
		/// .Net user control. If any other object (including MaxScript) is registered 
		/// for the event they will be notified.
		/// </summary>
		/// <param name="sender">The button that was pressed.</param>
		/// <param name="e">Generic EventArgs</param>
		private void _makeCircleButton_Click(object sender, EventArgs e)
		{
			if (CreateCircle != null)
			{
				CreateCircle(sender, e);
			}
		}

		/// <summary>
		/// The CreateLight event can be registered for by MaxScript so that when
		/// the event is raised MaxScript can take the appropriate action.
		/// </summary>
		public static event EventHandler CreateLight;
		private ColorDialog _colorDlg;

		/// <summary>
		/// This event will be called when the "Create Omni Light" button is clicked 
		/// on the .Net user control. If any other object (including MaxScript) 
		/// is registered for the event they will be notified.
		/// </summary>
		/// <param name="sender">The button that was pressed.</param>
		/// <param name="e">Generic EventArgs</param>
		private void _makeOmniLightButton_Click(object sender, EventArgs e)
		{
			if (CreateLight != null)
			{
				/// We want the user to pick a color before raising the event so we
				/// can pass that information along with our custom LightEventArgs.
				if (_colorDlg.ShowDialog() == DialogResult.OK)
				{
					CreateLight(sender, new LightEventArgs(_colorDlg.Color));
				}
			}
		}

		/// <summary>
		/// Simple method to show how functions on .Net objects can be called from
		/// MaxScript.
		/// </summary>
		public void SayHelloUserControl()
		{
			MessageBox.Show("Hello");
		}

		/// <summary>
		/// Simple method to show how functions on .Net object can be called from
		/// MaxScript.
		/// </summary>
		/// <param name="text">What should be printed in the .Net MessageBox
		/// </param>
		public void Say(string text)
		{
			MessageBox.Show(text);
		}
	}

	/// <summary>
	/// Sample custom EventArgs to illustrate how data can be passed to
	/// MaxScript through events. 
	/// The class encapsulates a color value for passing with the CreateLight event. 
	/// </summary>
	public class LightEventArgs : EventArgs
	{
		/// <summary>
		/// .Net Color object.
		/// </summary>
		private Color _color;

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="color">The color to be passed to MaxScript when
		/// creating a light.</param>
		public LightEventArgs(Color color)
		{
			_color = color;
		}

		/// <summary>
		/// Property: Used to access the color value.
		/// </summary>
		public Color LightColor
		{
			get
			{
				return _color;
			}
		}
	}
}