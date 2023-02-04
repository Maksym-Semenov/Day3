using System.Text;

string productName = "Олівець"; // назва продукту
double productPrice = 5.75;     // ціна однієї позиції продукту
double shippingPrice = 80;      // ціна доставки

// виконайте наступні дії
// 1 - покажіть користувачу назву та ціну товару
// 2 - запитайте скільки одиниць товару потрібно замовити, значення не може бути менше ніж 1
// 3 - запитайте чи потрібно виконувати доставку товару, якщо так ціна доставки shippingPrice інакше 0
// 4 - порахуйте вартість замовлених товарів з урахуванням кількості і доставки, та виведіть результат

Console.OutputEncoding = UTF8Encoding.UTF8;

int value = 0;
  
Console.WriteLine("Назва товару: " + productName + " Ціна: " + productPrice);
Console.Write("Введіть кількість товару для замовлення:  ");
value = Convert.ToInt32(Console.ReadLine());

while (value < 1 || value > 80)
{
    Console.WriteLine("Неправильна кількість товару");
    Console.Write("Введіть кількість товару для замовлення:  ");
    value = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Чи потрібна вам доставка?");
Console.WriteLine("Якщо ТАК, натисність + (плюс)");
Console.WriteLine("Якщо НІ, натисність - (мінус)");
string shipping = Console.ReadLine();

while (shipping != "+" | shipping == "-")
{
    Console.WriteLine("Введіть правильний знак");
    shipping = Console.ReadLine();
}
if (shipping == "+")
{
    double result1 = value * productPrice + shippingPrice;
    Console.WriteLine("Вартість товарів з урахуванням доставки " + result1);
}
else
{
    double result2 = value * productPrice;
    Console.WriteLine("Вартість товарів з урахуванням доставки " + result2);
}

Console.ReadLine();
