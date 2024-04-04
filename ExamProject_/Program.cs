using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        DictionaryApp dictionary = new DictionaryApp();
//        dictionary.Run();
//    }
//}
//class DictionaryApp
//{
//    private Dictionary<string, Dictionary<string, List<string>>> dictionaries;

//    public DictionaryApp()
//    {
//        dictionaries = new Dictionary<string, Dictionary<string, List<string>>>();
//    }
//    public void Run()
//    {
//        bool n = true;
//        while (n)
//        {
//            Console.WriteLine("1. Создать словарь");
//            Console.WriteLine("2. Добавить слово и перевод");
//            Console.WriteLine("3. Заменить слово или перевод");
//            Console.WriteLine("4. Удалить слово или перевод");
//            Console.WriteLine("5. Найти перевод слова");
//            Console.WriteLine("6. Экспортировать словарь");
//            Console.WriteLine("7. Выход");
//            Console.WriteLine();

//            Console.Write("Выберите действие-> ");
//            string userChoice = Console.ReadLine();

//            switch (userChoice)
//            {
//                case "1":
//                    CreateDictionary();
//                    break;
//                case "2":
//                    AddTranslation();
//                    break;
//                case "3":
//                    ReplaceTranslation();
//                    break;
//                case "4":
//                    RemoveTranslation();
//                    break;
//                case "5":
//                    SearchTranslation();
//                    break;
//                case "6":
//                    ExportDictionary();
//                    break;
//                case "7":
//                    n = false;
//                    break;
//                default:
//                    Console.WriteLine("Такого пункта нет");
//                    break;
//            }
//        }
//    }
//    private void CreateDictionary()
//    {
//        Console.Write("Введите название словаря: ");
//        string name = Console.ReadLine();
//        if  (!dictionaries.ContainsKey(name))
//        {
//            dictionaries[name] = new Dictionary<string, List<string>>();
//            Console.WriteLine($"Словарь '{name}' создан.");
//        }
//        else
//        {
//            Console.WriteLine($"Словарь с названием '{name}' уже существует.");
//        }
//    }

//    private void AddTranslation()
//    {
//        Console.Write("Введите название словаря, куда добавить перевод: ");
//        string dictionaryName = Console.ReadLine();
//        if (dictionaries.ContainsKey(dictionaryName))
//        {
//            Console.Write("Введите слово: ");
//            string word = Console.ReadLine();
//            Console.Write("Введите перевод: ");
//            string[] translations = Console.ReadLine().Split(',');
//            dictionaries[dictionaryName][word] = new List<string>(translations);
//            Console.WriteLine("Перевод(ы) добавлены в словарь.");
//        }
//        else
//        {
//            Console.WriteLine($"Словарь '{dictionaryName}' не найден.");
//        }
//    }
//    private void ReplaceTranslation()
//    {
//        Console.Write("Введите название словаря, где нужно заменить перевод: ");
//        string dictionaryName = Console.ReadLine();
//        if (dictionaries.ContainsKey(dictionaryName))
//        {
//            Console.Write("Введите слово, перевод которого нужно заменить: ");
//            string word = Console.ReadLine();
//            if (dictionaries[dictionaryName].ContainsKey(word))
//            {
//                Console.Write("Введите новый перевод(ы), разделяя их запятой: ");
//                string[] translations = Console.ReadLine().Split(',');
//                dictionaries[dictionaryName][word] = new List<string>(translations);
//                Console.WriteLine("Перевод(ы) заменены.");
//            }
//            else
//            {
//                Console.WriteLine($"Слово '{word}' не найдено в словаре.");
//            }
//        }
//        else
//        {
//            Console.WriteLine($"Словарь '{dictionaryName}' не найден.");
//        }
//    }
//    private void RemoveTranslation()
//    {
//        Console.Write("Введите название словаря, где нужно удалить перевод: ");
//        string dictionaryName = Console.ReadLine();
//        if (dictionaries.ContainsKey(dictionaryName))
//        {
//            Console.Write("Введите слово или его перевод для удаления: ");
//            string term = Console.ReadLine();
//            if (dictionaries[dictionaryName].ContainsKey(term))
//            {
//                dictionaries[dictionaryName].Remove(term);
//                Console.WriteLine("Перевод(ы) удалены.");
//            }
//            else
//            {
//                Console.WriteLine($"Слово или его перевод '{term}' не найдены в словаре.");
//            }
//        }
//        else
//        {
//            Console.WriteLine($"Словарь '{dictionaryName}' не найден.");
//        }
//    }

//    private void SearchTranslation()
//    {
//        Console.Write("Введите название словаря, в котором искать перевод: ");
//        string dictionaryName = Console.ReadLine();
//        if (dictionaries.ContainsKey(dictionaryName))
//        {
//            Console.Write("Введите слово для поиска перевода: ");
//            string word = Console.ReadLine();
//            if (dictionaries[dictionaryName].ContainsKey(word))
//            {
//                Console.WriteLine($"Перевод(ы) для '{word}':");
//                foreach (string translation in dictionaries[dictionaryName][word])
//                {
//                    Console.WriteLine(translation);
//                }
//            }
//            else
//            {
//                Console.WriteLine($"Слово '{word}' не найдено в словаре.");
//            }
//        }
//        else
//        {
//            Console.WriteLine($"Словарь '{dictionaryName}' не найден.");
//        }
//    }

//    private void ExportDictionary()
//    {
//        Console.Write("Введите название словаря для экспорта: ");
//        string dictionaryName = Console.ReadLine();
//        if (dictionaries.ContainsKey(dictionaryName))
//        {
//            string fileName = $"{dictionaryName}Dictionary.txt";
//            string filePath = Path.Combine(Environment.CurrentDirectory, fileName);
//            try
//            {
//                using (StreamWriter writer = new StreamWriter(filePath))
//                {
//                    foreach (var entry in dictionaries[dictionaryName])
//                    {
//                        writer.WriteLine(entry.Key + ": " + string.Join(", ", entry.Value));
//                    }
//                }
//                Console.WriteLine($"Словарь экспортирован в файл {fileName}.");
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine($"Ошибка при экспорте словаря: {e.Message}");
//            }
//        }
//        else
//        {
//            Console.WriteLine($"Словарь '{dictionaryName}' не найден.");
//        }
//    }

//}







//Задание 2

//namespace QuizApp
//{
//    class Program
//    {
//        static List<User> users = new List<User>();
//        static List<Quiz> quizzes = new List<Quiz>();
//        static void Main(string[] args)
//        {
//            quizzes.Add(new Quiz("История"));
//            quizzes.Add(new Quiz("География"));
//            quizzes.Add(new Quiz("Биология"));
//            quizzes[0].Questions.Add(new Question("Когда началась Вторая мировая война?", new List<string> { "1922", "1939" }, 1));
//            quizzes[0].Questions.Add(new Question("Когда закончилась Вторая мировая война?", new List<string> { "1945", "1940" }, 0));

//            quizzes[1].Questions.Add(new Question("Какая столица Украины?", new List<string> { "Харьков", "Киев" }, 1));
//            quizzes[1].Questions.Add(new Question("Какая столица Франции?", new List<string> { "Париж", "Варшава" }, 0));

//            quizzes[2].Questions.Add(new Question("Что выделяют растения в процессе фотосинтеза?", new List<string> { "Кислород", "Углекислый газ" }, 0));
//            quizzes[2].Questions.Add(new Question("Что поглощают растения в процессе фотосинтеза?", new List<string> { "Углекислый газ", "Кислород" }, 0));



//            bool running = true;
//            while (running)
//            {
//                Console.WriteLine("1. Вход");
//                Console.WriteLine("2. Регистрация");
//                Console.WriteLine("3. Выход");
//                Console.Write("Ввод: ");
//                string choice = Console.ReadLine();

//                switch (choice)
//                {
//                    case "1":
//                        Login();
//                        break;
//                    case "2":
//                        Register();
//                        break;
//                    case "3":
//                        running = false;
//                        break;
//                    default:
//                        break;
//                }
//            }
//        }

//        static void Login()
//        {
//            Console.WriteLine("Введите имя: ");
//            string username = Console.ReadLine();
//            Console.WriteLine("Введите пароль: ");
//            string password = Console.ReadLine();

//            User user = users.FirstOrDefault(u => u.Username == username && u.Password == password);
//            if (user != null)
//            {
//                UserMenu(user);
//            }
//        }
//        static void Register()
//        {
//            Console.WriteLine("Введите имя: ");
//            string username = Console.ReadLine();

//            Console.WriteLine("Введите пароль: ");
//            string password = Console.ReadLine();

//            Console.WriteLine("Введите дату рождения: ");
//            string dateOfBirth = Console.ReadLine();

//            users.Add(new User(username, password, dateOfBirth));
//        }

//        static void UserMenu(User user)
//        {
//            bool loggedIn = true;
//            while (loggedIn)
//            {
//                Console.WriteLine("\nМеню:");
//                Console.WriteLine("1. Начать игру");
//                Console.WriteLine("2. Посмотреть результаты прошлых игр");
//                Console.WriteLine("4. Изменить данные");
//                Console.WriteLine("5. Выйти");
//                Console.Write("Ввод: ");
//                string choice = Console.ReadLine();

//                switch (choice)
//                {
//                    case "1":
//                        StartNewQuiz(user);
//                        break;
//                    case "2":
//                        ViewPastResults(user);
//                        break;
//                    case "3":
//                        ChangeSettings(user);
//                        break;
//                    case "4":
//                        loggedIn = false;
//                        break;
//                    default:
//                        break;
//                }
//            }
//        }

//        static void StartNewQuiz(User user)
//        {
//            Console.WriteLine("Выберите категорию игры:");
//            for (int i = 0; i < quizzes.Count; i++)
//            {
//                Console.WriteLine($"{i + 1}. {quizzes[i].Topic}");
//            }
//            Console.WriteLine($"{quizzes.Count + 1}. Смешанная игра");

//            Console.Write("Введите номер категории: ");
//            int choice = int.Parse(Console.ReadLine());

//            if (choice >= 1 && choice <= quizzes.Count)
//            {
//                BeginQuiz(user, choice - 1);
//            }
//            else if (choice == quizzes.Count + 1)
//            {
//                BeginMixedQuiz(user);
//            }
//            else
//            {
//                Console.WriteLine("Ошибка");
//            }
//        }

//        static void BeginQuiz(User user, int quizIndex)
//        {
//            int score = 0;
//            Console.WriteLine($"Начало игры '{quizzes[quizIndex].Topic}'");

//            foreach (var question in quizzes[quizIndex].Questions)
//            {
//                Console.WriteLine(question.Text);
//                Console.WriteLine("Варианты ответов");
//                for (int i = 0; i < question.Answers.Count; i++)
//                {
//                    Console.WriteLine($"{i + 1}. {question.Answers[i]}");
//                }

//                Console.Write("Введите ответ: ");
//                int userAnswer = int.Parse(Console.ReadLine());

//                if (userAnswer == question.CorrectAnswerIndex + 1)
//                {
//                    Console.WriteLine("Ответ правильный");
//                    score++;
//                }
//                else
//                {
//                    Console.WriteLine("Ответ неправильный");
//                }
//            }
//            Console.WriteLine($"Игра закончена\nБалы: {score}/{quizzes[quizIndex].Questions.Count}");
//        }

//        static void BeginMixedQuiz(User user)
//        {
//            int score = 0;
//            foreach (var quiz in quizzes)
//            {
//                foreach (var question in quiz.Questions)
//                {
//                    Console.WriteLine(question.Text);
//                    Console.WriteLine("Варианты ответов");
//                    for (int i = 0; i < question.Answers.Count; i++)
//                    {
//                        Console.WriteLine($"{i + 1}. {question.Answers[i]}");
//                    }

//                    Console.Write("Введите ответ: ");
//                    int userAnswerIndex = int.Parse(Console.ReadLine());
//                    if (userAnswerIndex >= 1 && userAnswerIndex <= question.Answers.Count)
//                    {
//                        if (userAnswerIndex - 1 == question.CorrectAnswerIndex)
//                        {
//                            Console.WriteLine("\nОтвет правильный");
//                            score++;
//                        }
//                        else
//                        {
//                            Console.WriteLine("\nОтвет неправильный");
//                        }
//                    }
//                }
//            }
//            Console.WriteLine($"\nИгра окончена\nБалы: {score}/{quizzes.Sum(q => q.Questions.Count)}");
//        }

//        static void ViewPastResults(User user)
//        {
//            if (user.QuizResults.Count == 0)
//            {
//                Console.WriteLine("No past quiz results found.");
//                return;
//            }

//            foreach (var result in user.QuizResults)
//            {
//                Console.WriteLine($"Игра: {result.Quiz.Topic}");
//                Console.WriteLine($"Балы: {result.Score}/{result.TotalQuestions}");
//                Console.WriteLine("Ответы:");

//                for (int i = 0; i < result.UserAnswers.Count; i++)
//                {
//                    Console.WriteLine($"Вопросы {i + 1}: {string.Join(", ", result.UserAnswers[i].Select(x => x + 1))}");
//                }

//                Console.WriteLine();
//            }
//        }
//        class User
//        {
//            public string Username { get; set; }
//            public string Password { get; set; }
//            public string DateOfBirth { get; set; }
//            public List<QuizResult> QuizResults { get; set; }

//            public User(string username, string password, string dateOfBirth)
//            {
//                Username = username;
//                Password = password;
//                DateOfBirth = dateOfBirth;
//                QuizResults = new List<QuizResult>();
//            }
//        }
//        static void ChangeSettings(User user)
//        {
//            bool changingSettings = true;
//            while (changingSettings)
//            {
//                Console.WriteLine("Смена данных:");
//                Console.WriteLine("1. Изменить пароль");
//                Console.WriteLine("2. Изменить дату рождения");
//                Console.WriteLine("3. Назад к меню");
//                Console.Write("Ввод: ");
//                string choice = Console.ReadLine();

//                switch (choice)
//                {
//                    case "1":
//                        Console.WriteLine("Введите новый пароль:");
//                        string newPassword = Console.ReadLine();
//                        user.Password = newPassword;
//                        Console.WriteLine("Вы поменяли пароль");
//                        break;
//                    case "2":
//                        Console.WriteLine("Введите новую дату рождения:");
//                        string newDateOfBirth = Console.ReadLine();
//                        user.DateOfBirth = newDateOfBirth;
//                        Console.WriteLine("Вы поменяли дату рождения");
//                        break;
//                    case "3":
//                        changingSettings = false;
//                        break;
//                    default:
//                        break;
//                }
//            }
//        }
//        class Quiz
//        {
//            public string Topic { get; set; }
//            public List<Question> Questions { get; set; }

//            public Quiz(string topic)
//            {
//                Topic = topic;
//                Questions = new List<Question>();
//            }
//        }
//        class Question
//        {
//            public string Text { get; set; }
//            public List<string> Answers { get; set; }
//            public int CorrectAnswerIndex { get; set; }

//            public Question(string text, List<string> answers, int correctAnswerIndex)
//            {
//                Text = text;
//                Answers = answers;
//                CorrectAnswerIndex = correctAnswerIndex;
//            }
//        }
//        class QuizResult
//        {
//            public Quiz Quiz { get; set; }
//            public int Score { get; set; }
//            public int TotalQuestions { get; set; }
//            public List<List<int>> UserAnswers { get; set; }

//            public QuizResult(Quiz quiz, int score, int totalQuestions)
//            {
//                Quiz = quiz;
//                Score = score;
//                TotalQuestions = totalQuestions;
//                UserAnswers = new List<List<int>>();
//            }
//        }
//    }
//}
