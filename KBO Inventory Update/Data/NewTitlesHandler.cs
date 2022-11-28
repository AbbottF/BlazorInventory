using IgniteUI.Blazor.Controls;
using KBO_Inventory_Update.NewTitles;

namespace KBO_Inventory_Update.
{
    public class NewTitlesHandler
    {

        public bool UpdateInventoryItem(IgbRowType row)
        {
            bool anyProblems = true;
            BookType book = LoadBookData(row);
            // call load inventory with await
            return anyProblems;
        }
        private BookType LoadBookData(IgbRowType row)
        {

            BookType book = new BookType();
            object parser = "";
            foreach (var cell in row.Cells)
            {
                switch (cell.Name)
                {
                    case "ISBN":
                        book.ISBN = cell.Value.ToString();
                        break;
                    case "Title":
                        book.Title = cell.Value.ToString();
                        break;
                    case "Author":
                        book.Author = cell.Value.ToString();
                        break;
                    case "Publisher":
                        book.Publisher = cell.Value.ToString();
                        break;
                    case "Category":
                        book.Category = cell.Value.ToString();
                        break;
                    case "Subject":
                        book.Subject = cell.Value.ToString();
                        break;
                    case "Binding":
                        book.Binding = cell.Value.ToString();
                        break;
                    case "ListUSD":
                        book.ListUSD = double.Parse(cell.Value.ToString());
                        break;
                    case "NetUSD":
                        book.NetUSD = double.Parse(cell.Value.ToString());
                        break;
                    case "AvaliableQuantity":
                        book.AvaliableQuantity = Int32.Parse(cell.Value.ToString());
                        break;
                    case "Blowout":
                        book.Blowout = cell.Value.ToString();
                        break;
                    case "Category2":
                        book.Category2 = cell.Value.ToString();
                        break;
                    case "Category3":
                        book.Category3 = cell.Value.ToString();
                        break;
                    case "Subject2":
                        book.Subject2 = cell.Value.ToString();
                        break;
                    case "Subject3":
                        book.Subject3 = cell.Value.ToString();
                        break;
                    case "Age":
                        book.Age = cell.Value.ToString();
                        break;
                    case "CalendarEvent":
                        book.CalendarEvent = cell.Value.ToString();
                        break;
                    default:
                        break;
                }
            }
            return book;
        }
    }
}
