using HashTable;

static class Programm
{
    static Random rnd = new Random();
    public static void Main()
    {
        Table table = new Table();
        table.Add(12);
        table.Add(13);
        table.Add(15);
        table.Add(19);
        table.Add(18);
        table.Add(58);
        table.Add(258);
        table.Add(5228);
        table.Add(5518);
        table.Add(5815615);
        table.Add(581156);

        var vr = table.Search(25858);
    }
}