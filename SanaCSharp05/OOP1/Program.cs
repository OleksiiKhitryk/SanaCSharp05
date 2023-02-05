using OOP1;


Date startDate = new Date("2023", "01", "Monday", "08", "00");
Date finishDate = new Date("2023", "01", "Monday", "08", "20");
Date finishDate1 = new Date("2024", "04", "Friday", "06", "55");

Airplane airplane1 = new Airplane("Zhitomir", "Kiev", startDate, finishDate);
//Airplane airplane2 = new Airplane("Kiev", "Zhitomir", startDate, finishDate);

airplane1.SetFinishDate(finishDate1);

//finishDate1.SetDay("Tuesday");

airplane1.PrintInfo();
//airplane2.PrintInfo();

Console.WriteLine(airplane1.IsArrivingToday(startDate.GetDay(), finishDate1.GetDay()));
