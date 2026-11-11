string fullName = "Блудилин Артём Иванович";
string groupName = "ИСП-252";
int courseNumber = 2;
string specialty = "09.02.07";
bool isBudget = true;

double grade1 = 5.0;
double grade2 = 4.0;
double grade3 = 4.0;

double averageGrade = (grade1 + grade2 + grade3) / 3.0;

const double ScholarshipThreshold = 4.0;
bool isScholarshipEligible = averageGrade >= ScholarshipThreshold;

int totalWeeksInSemester = 20;
int weeksPassed = 4;
int weeksLeft = totalWeeksInSemester - weeksPassed;

Console.WriteLine("================================");
Console.WriteLine("ВИЗИТНАЯ КАРТОЧКА СТУДЕНТА");
Console.WriteLine("================================");
Console.WriteLine($"ФИО: {fullName}");
Console.WriteLine($"Группа: {groupName}");
Console.WriteLine($"Курс: {courseNumber}");
Console.WriteLine($"Специальность: {specialty}");
Console.WriteLine();
Console.WriteLine($"Средний балл за 3 работы: {averageGrade:F2}");
Console.WriteLine($"Стипендия положена (>= {ScholarshipThreshold}): {isScholarshipEligible}");
Console.WriteLine($"Бюджетное место: {isBudget}");
Console.WriteLine();
Console.WriteLine($"Учебных недель осталось в семестре: {weeksLeft}");
Console.WriteLine("================================");