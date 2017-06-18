using System.Collections.Generic;
using System.Linq;

namespace BookShop
{
    public class BookShop
    {
        public decimal GetBillPrice(List<Book> books)
        {
            var count = books.Count(x => x.Count > 0);
            var sum = 0.0m;
            while (count > 0)
            {
                sum += books.Sum(x => x.SinglePrice * ((x.Count > 0) ? 1 : 0) * GetDiscount(count));
                foreach (var book in books)
                {
                    book.Count = book.Count - 1;
                }
                count = books.Count(x => x.Count > 0);
            }

            return sum;
        }

        private decimal GetDiscount(int count)
        {
            var Discounts = new Dictionary<int, decimal>
            {
                {1, 1},
                {2, 0.95m},
                {3, 0.90m},
                {4, 0.80m},
                {5, 0.75m}
            };
            return Discounts[count];
        }
    }


}
public class Book
{
    public decimal SinglePrice { get; set; }
    public string Name { get; set; }
    public int SerialNo { get; set; }
    public int Count { get; set; }
}