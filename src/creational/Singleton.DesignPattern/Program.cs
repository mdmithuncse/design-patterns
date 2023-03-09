// See https://aka.ms/new-console-template for more information
using Singleton.DesignPattern;

Console.WriteLine("Hello, This is the example of singleton design pattern!");

#region Implementation of vote machine example

Console.WriteLine("Implementation of vote machine example");

var numbers = Enumerable.Range(0, 10);

Parallel.ForEach(numbers, x =>
{
    var vm = VoteMachine.Instance;
    vm.RegisterVote();
});

Console.WriteLine(VoteMachine.Instance.TotalVotes);

#endregion

#region Implementation of print message example

Console.WriteLine("Implementation of print message example");

Parallel.Invoke(
        () => PrintTeacherMessage(),
        () => PrintStudentMessage()
    );

static void PrintTeacherMessage()
{
    PrintMessage fromTeacher = PrintMessage.Instance;
    fromTeacher.Print("From Teacher");
}

static void PrintStudentMessage()
{
    PrintMessage fromStudent = PrintMessage.Instance;
    fromStudent.Print("From Student");
}

#endregion