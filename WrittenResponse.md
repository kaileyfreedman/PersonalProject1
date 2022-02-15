# Guessing Game Written Response

The format for this document are taken directly from the AP Computer Science
Principles [Student Handout](../support/ap-csp-student-task-directions.pdf).

## 3a

Provide a written response that does all three of the following:

### 3a i.

Describes the overall purpose of the program. 

A person would run my program to determine what chicken preparation they are for entertainment. 

### 3a ii.

Describes what functionality of the program is demonstrated in the video.

This video demonstrates that my program can perform a personality quiz.  

### 3a iii.

Describes the input and output of the program demonstrated in the video.

My program accepts user input from the keyboard. For each question they enter the option that they want. Then it outputs a calculated result from the users inputs. 

## 3b

Capture and paste two program code segments you developed during the
administration of this task that contain a list (or other collection type) being
used to manage complexity in your program.

### 3b i.

The first program code segment must show how data have been stored in the list.

```csharp
List<int> scores = new List<int>();
scores.Add(0);
scores.Add(0);
scores.Add(0);
scores.Add(0);
scores.Add(0);
```

### 3b ii.

The second program code segment must show the data in the same list being used,
such as creating new data from the existing data or accessing multiple elements
in the list, as part of fulfilling the program's purpose.

```csharp
foreach (int score in scores)
{
    if (score > largestScore)
    {
    associatedResult = results[index];
    largestScore = scores[index];
    }
    index = index + 1;
 }
```

### 3b iii.

Then provide a written response that does all three of the following:

Identifies the name of the list being used in this response

The list is stored in "scores".

### 3b iv.

Describes what the data contained in the list represents in your program

This list contains the different scores for each of the options that the user selects. 

### 3b v.

Explains how the selected list manages complexity in your program code by
explaining why your program code could not be written, or how it would be
written differently, if you did not use the list.

My list manages complexity because I could easily add more questions without changing my code. Without the loop, I would have to create additional variables each time I add a question. 

## 3c.

Capture and paste two program code segments you developed during the
administration of this task that contain a student-developed procedure that
implements an algorithm used in your program and a call to that procedure.

### 3c i.

The first program code segment must be a student-developed procedure that:

- [ ] Defines the procedure's name and return type (if necessary)
- [ ] Contains and uses one or more parameters that have an effect on the functionality of the procedure
- [ ] Implements an algorithm that includes sequencing, selection, and iteration

```csharp
public static int AskQuestion(Question question)
{
    if (question == null) throw new ArgumentNullException("List of question may not be null.");
    if (question.answers.Count == 0) throw new ArgumentException("The list of question must contain at least 1 option.");
    Console.WriteLine(question.question);
    int ix = 1;
    foreach (string answer in question.answers)
    {
        Console.WriteLine($"{ix}. {answer}");
        ix = ix + 1;
    }
    return GetValidAnswer(question.answers);
}
```

### 3c ii.

The second program code segment must show where your student-developed procedure is being called in your program.

```csharp
return GetValidAnswer(question.answers);
```

### 3c iii.

Describes in general what the identified procedure does and how it contributes to the overall functionality of the program.

At a high level, this method displays a question, a list of answers, and waits for the user to input a valid answer. This is a crucial part to the functionality of my program. 

### 3c iv.

Explains in detailed steps how the algorithm implemented in the identified procedure works. Your explanation must be detailed enough for someone else to recreate it.

1) Display the question
2) Loop through each answer and display it
3) Use the GetValidAnswer method to get the user's response
4) Return the user's response
   
## 3d

Provide a written response that does all three of the following:

### 3d i.

Describes two calls to the procedure identified in written response 3c. Each call must pass a different argument(s) that causes a different segment of code in the algorithm to execute.

First call:

testQuestion = new Question();
testQuestion.question = "Will Brooklin win the lottery?";
testQuestion.answers.Add("Yes she will!");
testQuestion.answers.Add("Not this time.");
testQuestion.answers.Add("She does not like the lottery.");

result = Program.AskQuestion(testQuestion);
expected = 1;

Second call:

Program.AskQuestion(null);

### 3d ii.

Describes what condition(s) is being tested by each call to the procedure

Condition(s) tested by the first call: 
 
This tests that the method runs when the input is not null.

Condition(s) tested by the second call:

This tests that the method fails when the input is null by throwing an exception. 

### 3d iii.

Result of the first call:

The result is that question is asked and the user has to enter a valid answer.

Result of the second call:

The result is an exception is thrown. 