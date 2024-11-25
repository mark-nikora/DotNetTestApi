### Relationships

<span style="color: blue">Test 1---M TestQuestion M---1 Question</span>

<span style="color: blue">Question 1---M Option</span>

<span style="color: blue">QuestionBank 1---M QBQuestion M---1 Question</span>

<span style="color: blue">ATest 1---M Result</span>

<span style="color: blue">Result M---1 ATest 1---M ATestQuestion M---1 AQuestion</span>

---

### Deletion Policy
Test
Test and testquestion and questions deleted
if the question is used in another test or in a question bank it remains
delete question bank and qbquestions.
questions only deleted if not used in any qbank or test

Result
when a result is created 
the test, testquestions, and questions are copied to 
Atest, Atestquestions, Aquestions archive tables
if a result is created for a test that is already archived then it is related to the archive

---

### Models

BaseModel
Test
Result
TestQuestion
Question
Option
QuestionBank
QBQuestion
ATestQuestion
ATest
AQuestion

---

**BaseModel** - done
CreatedAt
UpdatedAt

**Test** - done
id
name
description


**Result** - done
id
ATestId
mark
username
outof (possibly derived)

**Question** - done
id
description

**TestQuestion** (join table) - done
id
TestId(FK)
QuestionId(FK)

**QuestionBank** - done
id
name
description
´
**QBQuestion** - done
id
questionBankId(FK)
questionId(FK)

**Option**
id
description
correct
quesitonId(FK)

#####  Archive Tables
ATest
ATestQuestion
AQuestion






