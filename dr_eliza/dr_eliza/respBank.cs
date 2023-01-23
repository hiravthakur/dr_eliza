using System;
namespace dr_eliza
{
	//A structure (template) to store keywords and their prefabricated responses.
	public struct respBank
	{
		public string keyword;

		public string[] LoR;


		//Method creates a list of the respBank structures so it may be used in the Main function.
		public respBank[] applyBank()
		{
			respBank one;
			one.keyword = "hello";
			one.LoR = new string[] { "How do you do. Please state your problem." };

			respBank two;
			two.keyword = "computer";
			two.LoR = new string[] {"Do computers worry you?",
	"What do you think about machines?",
	"Why do you mention computers?",
	"What do you think machines have to do with your problem?"};

			respBank three;
			three.keyword = "name";
			three.LoR = new string[] { "I am not interested in names" };

			respBank four;
			four.keyword = "sorry";
			four.LoR = new string[] {"Please don't apologize",
	"Apologies are not necessary",
	"What feelings do you have when you apologize"};

			respBank five;
			five.keyword = "i remember";
			five.LoR = new string[] {"Do you often think of $?",
	"Does thinking of $ bring anything else to mind?",
	"What else do you remember?",
	"Why do you recall $ right now?",
	"What in the present situation reminds you of $?",
	"What is the connection between me and $?"};

			respBank six;
			six.keyword = "do you remember";
			six.LoR = new string[] {"Did you think I would forget $?",
	"Why do you think I should recall $ now?",
	"What about $?",
	"You mentioned $"};

			respBank seven;
			seven.keyword = "i want";
			seven.LoR = new string[] {"What would it mean if you got $?",
	"Why do you want $?",
	"Suppose you got $ soon."};

			respBank eight;
			eight.keyword = "i dreamt";
			eight.LoR = new string[] { "How do you feel about $ in reality?" };

			respBank nine;
			nine.keyword = "dream";
			nine.LoR = new string[] {"What does this dream suggest to you?",
	"Do you dream often?",
	"What persons appear in your dreams?",
	"Don't you believe that dream has to do with your problem?"};

			respBank ten;
			ten.keyword = "my mother";
			ten.LoR = new string[] { "Tell me more about your family" };

			respBank eleven;
			eleven.keyword = "my father";
			eleven.LoR = new string[] {"Your father?",
	"Does he influence you strongly?",
	"What else comes to mind when you think of your father?"};

			respBank twelve;
			twelve.keyword = "i am glad";
			twelve.LoR = new string[] {"How have I helped you to be $?",
	"What makes you happy just now?",
	"Can you explain why you are suddenly $?"};

			respBank thirteen;
			thirteen.keyword = "i am sad";
			thirteen.LoR = new string[] {"I am sorry to hear you are depressed",
	"I'm sure it's not pleasant to be sad"};

			respBank fourteen;
			fourteen.keyword = "alike";
			fourteen.LoR = new string[] {"In what way?",
	"What similarities are there?"};

			respBank fifteen;
			fifteen.keyword = "same";
			fifteen.LoR = new string[] { "What other connections do you see?" };

			respBank sixteen;
			sixteen.keyword = "no";
			sixteen.LoR = new string[] {"Why not?",
	"You are being a bit negative.",
	"Are you saying 'No' just to be negative?"};

			respBank seventeen;
			seventeen.keyword = "i was";
			seventeen.LoR = new string[] {"Were you really?",
	"Perhaps I already knew you were $.",
	"Why do you tell me you were $ now?"};

			respBank eighteen;
			eighteen.keyword = "was i";
			eighteen.LoR = new string[] {"What if you were $?",
	"Do you think you were $?",
	"What would it mean if you were $?"};

			respBank nineteen;
			nineteen.keyword = "i am";
			nineteen.LoR = new string[] {"In what way are you $?",
	"Do you want to be $?"};

			respBank twenty;
			twenty.keyword = "am i";
			twenty.LoR = new string[] {"Do you believe you are $?",
	"Would you want to be $?",
	"You wish I would tell you you are $?",
	"What would it mean if you were $?"};

			respBank twentyOne;
			twentyOne.keyword = "are you";
			twentyOne.LoR = new string[] {"Why are you interested in whether I am $ or not?",
	"Would you prefer if I weren't $?",
	"Perhaps I am $ in your fantasies"};

			respBank twentyTwo;
			twentyTwo.keyword = "you are";
			twentyTwo.LoR = new string[] { "What makes you think I am $?" };

			respBank twentyThree;
			twentyThree.keyword = "because";
			twentyThree.LoR = new string[] {
	"Is that the real reason?",
	"What other reasons might there be?",
	"Does that reason seem to explain anything else?"};

			respBank twentyFour;
			twentyFour.keyword = "were you";
			twentyFour.LoR = new string[] {"Perhaps I was $?",
	"What do you think?",
	"What if I had been $?"};

			respBank twentyFive;
			twentyFive.keyword = "i can't";
			twentyFive.LoR = new string[] {"Maybe you could $ now",
	"What if you could $?"};

			respBank twentySix;
			twentySix.keyword = "i feel";
			twentySix.LoR = new string[] { "Do you often feel $?" };

			respBank twentySeven;
			twentySeven.keyword = "i felt"; ;
			twentySeven.LoR = new string[] { "What other feelings do you have?" };

			respBank twentyEight;
			twentyEight.keyword = "why don't you";
			twentyEight.LoR = new string[] {"Should you $ yourself?",
	"Do you believe I don't $?",
	"Perhaps I will $ in good time"};

			respBank twentyNine;
			twentyNine.keyword = "yes";
			twentyNine.LoR = new string[] {"You seem quite positive",
	"You are sure?",
	"I understand"};

			respBank thirty;
			thirty.keyword = "somebody";
			thirty.LoR = new string[] { "Can you be more specific?" };

			respBank thirtyOne;
			thirtyOne.keyword = "everybody";
			thirtyOne.LoR = new string[] { "Surely not everyone",
	"Can you think of anyone in particular?",
	"Who, for example?",
	"You are thinking of a special person"};

			respBank thirtyTwo;
			thirtyTwo.keyword = "always";
			thirtyTwo.LoR = new string[] {"Can you think of a specific example?",
	"When?",
	"What incident are you thinking of?",
	"Really--always?"};

			respBank thirtyThree;
			thirtyThree.keyword = "what";
			thirtyThree.LoR = new string[] {"Why do you ask?",
	"Does that question interest you?",
	"What is it you really want to know?",
	"What do you think?",
	"What comes to your mind when you ask that?"};

			respBank thirtyFour;
			thirtyFour.keyword = "perhaps";
			thirtyFour.LoR = new string[] { "You do not seem quite certain" };

			respBank thirtyFive;
			thirtyFive.keyword = "are";
			thirtyFive.LoR = new string[] {"Did you think they might not be $?",
	"Possibly they are $"};

			respBank[] LoRR = new respBank[] { one, two, three, four, five, six, seven, eight,
			nine, ten, eleven, twelve, thirteen, fourteen, fifteen, sixteen, seventeen, eighteen, nineteen,
			twenty, twentyOne, twentyTwo, twentyThree, twentyFour, twentyFive, twentySix, twentySeven,
			twentyEight, twentyNine, thirty, thirtyOne, thirtyTwo, thirtyThree, thirtyFour, thirtyFive};

			return LoRR;
        }

	}
}

