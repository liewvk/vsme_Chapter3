using System.Globalization;

decimal unitPrice = 12.50m;
int quantity = 3;
decimal rate = 0.06m;
decimal subtotal = unitPrice * quantity;
decimal charge = Math.Round(subtotal * rate, 2);
decimal total = subtotal + charge;
Console.WriteLine("Subtotal: " +
    subtotal.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Charge: " +
    charge.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine("Total: " +
    total.ToString("F2", CultureInfo.InvariantCulture));

