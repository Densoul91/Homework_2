Console.WriteLine("Добрый день!");
var number = 0;
var answer = "";

string? company = null;    
do
{
    Console.Write("Введите название компании: ");
    company = Console.ReadLine();
}
while (String.IsNullOrEmpty(company));

while (true)
{
    string? lastName = null;
    do
    {
        Console.Write("\nВведите вашу фамилию: ");
        lastName = Console.ReadLine();
    }
    while (String.IsNullOrEmpty(lastName));

    string? firstName = null;
    do
    {
        Console.Write("Введите ваше имя: ");
        firstName = Console.ReadLine();
    }
    while (String.IsNullOrEmpty(firstName));

    string? patronymic = null;
    do
    {
        Console.Write("Введите ваше отчество: ");
        patronymic = Console.ReadLine();
    }
    while (String.IsNullOrEmpty(patronymic));

    string? strAge = null;
    do
    {
        Console.Write("Введите ваш возраст: ");
        strAge = Console.ReadLine();
    }
    while(String.IsNullOrEmpty(strAge));
    
    var age = Convert.ToInt32(strAge);
    if (age < 18|age>=65)
    {
        Console.WriteLine($"Неверный возраст");
        do
        {
            Console.Write("Ввести сотрудника заново? (да/нет): ");
            answer = Console.ReadLine() switch
            {
                "да" => "да",
                "нет" => "нет",
                _ => "ошибка",
            };
         }
        while (answer == "ошибка");
        if (answer == "да")
            continue;
        else 
            break;

    }
    string? gender = null;
    do
    {
        Console.Write("Введите ваш пол (м/ж): ");
        gender = Console.ReadLine();
    }
    while (String.IsNullOrEmpty(gender) || (gender != "м" && gender != "ж"));
    var prefix = gender == "м" ? "Уважаемый" : "Уважаемая";

    var post = "";
    do
    {
        Console.Write("Введите должность: ");
        var inputPost= Console.ReadLine();
        inputPost = inputPost.ToLower();
        post = inputPost switch
        {
            "менеджер" => "менеджер",
            "программист" => "программист",
            "тестировщик" => "тестировщик",
            "руководитель проекта" => "руководитель проекта",
            "директор" => "директор",
            _ => "ошибка",
        };
        if (post == "ошибка") Console.WriteLine("\nДолжность не существует!");
    }
    while (post == "ошибка");

    Console.WriteLine($"\n\n{prefix}, {lastName} {firstName} {patronymic}, {age} лет, {post},\nспасибо за внесение данных о себе!\n");
    number++;

    do
    {
        Console.Write("Продолжить ввод сотрудников? (да/нет): ");
        answer = Console.ReadLine() switch
        {
            "да" => "да",
            "нет" => "нет",
            _ => "ошибка",
        };
    }
    while (answer == "ошибка");
    if (answer == "да")
        continue;
    else
        break;
}
Console.WriteLine($"В компанию {company} добавлено {number} сотрудник(-а,-ов)\nСпасибо за использование нашей программы!");
