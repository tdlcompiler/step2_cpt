namespace OOP_1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, CPT!");

            BankAccount bankAccount = new(199);
            Console.WriteLine($"Аккаунт после инициализации без указания имени.");
            Console.WriteLine($"Аккаунт \"{bankAccount.OwnerName}\". Баланс = {bankAccount.Balance}.");
            bankAccount.AddRubles(200);
            Console.WriteLine($"Аккаунт \"{bankAccount.OwnerName}\". Обновлённый баланс = {bankAccount.Balance}.");
            bankAccount.OwnerName = "Тёмыч";
            Console.WriteLine($"Тот же аккаунт с новым именем \"{bankAccount.OwnerName}\". Баланс = {bankAccount.Balance}.\n");

            BankAccount bankAccount2 = new(0, "Denis");
            Console.WriteLine($"Аккаунт после инициализации с указанием имени.");
            Console.WriteLine($"Аккаунт \"{bankAccount2.OwnerName}\". Нищий баланс = {bankAccount2.Balance}.");
            bankAccount2.AddRubles(5000);
            Console.WriteLine($"Аккаунт \"{bankAccount2.OwnerName}\". УРА, СТИПУХА. Ваш баланс = {bankAccount2.Balance}.");
            bankAccount2.WithdrawRubles(5000);
            Console.WriteLine($"Аккаунт \"{bankAccount2.OwnerName}\". Вот и нет стипухи. Ваш баланс = {bankAccount2.Balance}.");
        }
    }
}