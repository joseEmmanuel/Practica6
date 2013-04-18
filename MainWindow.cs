using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnFacturaClicked (object sender, EventArgs e)
	{
		double p1 = double.Parse (this.Producto1.Text);
		double p2 = double.Parse (this.Producto2.Text);
		double p3 = double.Parse (this.Producto3.Text);

		double subtotal = (p1 + p2 + p3);
		double iva = (subtotal * .16);
		double total = (subtotal + iva);

		this.Subtotal.Text = subtotal.ToString();
		this.IVA.Text = iva.ToString();
		this.Total.Text = total.ToString();
	
	}

	protected void OnLimpiarClicked (object sender, EventArgs e)
	{
		this.Producto1.Text = "";
		this.Producto2.Text = "";
		this.Producto3.Text = "";

		this.Subtotal.Text = "";
		this.IVA.Text = "";
		this.Total.Text = "";

	}
}
