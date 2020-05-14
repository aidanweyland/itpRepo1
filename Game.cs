using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace No_Edge
{
	class Game
	{
		private Player CurrentPlayer;
		private Prompt prompt1;
		private Prompt prompt2;
		private Prompt prompt3;
		private Prompt prompt4;
		private Prompt prompt5;
		private Prompt prompt6;
		private Prompt prompt7;
		private Prompt prompt8;
		private Prompt prompt9;
		private Prompt prompt10;
		private Prompt prompt10v;
		private Prompt prompt11;
		private Prompt prompt12;
		private Prompt prompt13;
		private Prompt prompt14;
		private Prompt prompt15;
		private Prompt prompt16;
		private Prompt prompt17;
		private Prompt prompt18;
		private Prompt prompt19;
		private Prompt prompt20;
		private Prompt prompt21;
		private Prompt prompt22;
		private Prompt prompt23;
		private Prompt prompt24;
		private Prompt prompt25;
		private Prompt prompt26;
		private Prompt prompt27;
		private Prompt prompt28;
		private Prompt prompt29;
		private Prompt prompt30;
		private Prompt prompt31;
		public Game()
		{
			CurrentPlayer = new Player();
			prompt1 = new Prompt(@" Woman: “Major!”

 I look up and meet eyes with a middle-aged woman unbuckling my harness. I must have
 slept through the descent to the surface.

 Woman: “The mission director is ready to speak with you as soon as you are able, she
 seemed serious”

 I look down at her name tag. It reads Sera.

 Sera: “Is it serious, major?”", @"
 1. “Sorry, Sera, I’m really not allowed to discuss it.”

 2. “Budget stuff is all, guys back in Washington want to cut spending.”

 3. “I’m not sure yet. Did she say anything else about what she wanted to talk about?”

 4. Say nothing and stare Blankly.");
			prompt2 = new Prompt(@" Sera: “Oh of course, sorry major. They have prepared a room for you in the west wing, 
 there is food and clothes waiting for you after the meeting. Let me show you to the
 director’s office”", "");
			prompt3 = new Prompt(@" Sera: “Really? I always assumed budgetary matters were handled in the city offices. Well,
 I’ll show you your room once you're finished speaking with director Tali. Just ask for
 Sera, that’s me.”", "");
			prompt4 = new Prompt(@" Sera: “No, she was unusually tight lipped. She almost seemed distressed by your arrival...
 I probably shouldn’t be putting words in her mouth… Sorry, I’ll show you to the director’s
 office.”", "");
			prompt5 = new Prompt(@" Sera: “Well. Sorry I asked. Please follow me to the director's office.”", @"");
			prompt6 = new Prompt(@" I follow Sera down a long series of hallways in uneven silence save for the clip-clap
 of her heels on the laminated floors. My mind starts to wander. I imagining what lies ahead
 of me in that office. Director Tali must be in her 70’s by now, the last time I spoke with
 her I was just an applicant in training. Now that I think about it, that season was the only
 time I have ever been in Ares. It's a massive complex of labs, training facilities, and launch
 pads. It was built back in the 40s... back when the government took space travel seriously.
 Supposedly the entire space program could be run from Ares if needed for whatever reason. 
 I snap back to the present and nearly walk into Sera. 

 Sera: “We’re here. Good luck Major.”

 She opens the door. The office is smaller than I remember it.

 Tali: “Thank you Sera, you can leave us, and please shut the door. Hello Major, I trust you
 had a good flight.”
", @"
 1. “What is the situation, ma’am.”

 2. “It was smooth enough. How are you ma’am?”

 3. “You have a lot of nerve dragging me out here, you know that?”
");
			prompt7 = new Prompt(@" Tali: “The bottom line is this. Find the object and once we know what it is, our guys
 at base will decide what to do with it. All other objectives are secondary; it’s
 just easier that way. Unless you have any further questions, I’ll call Sera back
 to show you your room.”", @"
 1. “But why me? I haven't flown a mission past mars in years.”

 2. “Is that all we really know about it? None of our scientists have any hypotheses
 about the object?”

 3. “I’m good for now ma’am”");
			prompt8 = new Prompt(@" “Got it Major?”", @"
 1. “Yes, sorry ma’am.”

 2. “You think I would fuck this up? Please, this is Major Kadar you’re talking to.”");
			prompt9 = new Prompt(@" Tali nods and presses a button on her desk.

 “Sera, please show Major Kadar to their room”

 She releases her finger and raises from her desk. She opens the door.

 “Make your country proud, major.”

 Sera is waiting for me and motions to follow her. I followed Sera east through the
 halls and corridors. She stopped in front of the door with my name already on the
 electronic display.

 Sera: “Here you are, major. I hope you find everything to your liking.” 
", @"");
			prompt10 = new Prompt(@" Sera walks down the hall and leaves me by myself. I walk into my room and sit down
 on the bed.

 Electronic Voice: “Major Kadar.”

 “Mission scheduled for oh seven hundred tomorrow morning.”

 I look down at my watch, 7:42, I’m not really tired, but then again, I might need all the
 sleep I can get for the launch tomorrow.", @"
 1. Get ready for bed.

 2. Explore the Ares base.");
			prompt10v = new Prompt(@" Sera walks down the hall and leaves me by myself. I walk into my room and sit down
 on the bed.

 Electronic Voice: “Major Kadar.”

 “Mission scheduled for oh seven hundred tomorrow morning.”

 I look down at my watch, 7:42, I’m not really tired, but then again, I might need all
 the sleep I can get for the launch tomorrow.", @"
1.Get ready for bed.

2.Explore the Ares base.

3. Visit Intersolar command.");

		    prompt11 = new Prompt(@" Kadar: “Sera, Can I trust you?”

 She seems taken aback at first.

 Sera: “Of course you can, it's my job to be of help to you.”

 I take a deep breath and look at her.", @"
 1. “Any advice before the mission?”

 2. “There has to be someone in this base that knows more about this object. Who would that be?”

 3. “Do you think I can trust director Tali?”");
			prompt12 = new Prompt("", "");
			prompt13 = new Prompt("", "");
			prompt14 = new Prompt(@"", @"");
			prompt15 = new Prompt(@" I open the door to my room and look up and down the hall.
 Empty. I walk down the hall to the junction that led to director Tali’s office and turn
 the other direction. I see a sign with the names of all the labs on this floor, three
 catch my eye.", @"
 1. Intersolar command

 2. Extrasolar command

 3. Experimental technologies");
			prompt16 = new Prompt("", "");
			prompt17 = new Prompt("", "");
			prompt18 = new Prompt(@" After making sure there was no one in the hall, I walk down to the lab marked
 'Experimental Technologies’. I stand before the door and reach out to- *KADAR
 IDENTIFIED * A red light scans over my face and a robotic voice welcomes me in. The
 lights in the hallway dim and an inviting warm glow draws me through the doorway. As
 soon as I enter the room the door closes and locks behind me. Nowhere to go but
 forward.Slowly I creep down the expansive hallway. Whispers, just too quiet to make
 out, fill the air, each time I look to see who's there, nothing. After a small eternity
 of walking, I’m met with another locked door with my name printed in all caps.This
 door is much older than any of the others in the base.", @"
 1. Push through

 2. Turn back");
			prompt19 = new Prompt(@" I push the door op- wait a second… what am I doing? I was given the honor of a
 lifetime to serve my country… what am I doing snooping around these hallways? I
 should turn back and just go to sleep. But then again, this door says my name, what
 are they keeping from me?", @"
 1. Push through

 2. Turn back");
			prompt20 = new Prompt(@" I push the door op- wait a second… what am I doing? I was given the honor of a
 lifetime to serve my country… what am I doing snooping around these hallways? I
 should turn back and just go to sleep. But then again, this door says my name, what
 are they keeping from me?", @"
 1. Push through

 2. Turn back");
			prompt21 = new Prompt(@" I push the door op- wait a second… what am I doing? I was given the honor of a
 lifetime to serve my country... what am I doing snooping around these hallways? I
 should turn back and just go to sleep. But then again, this door says my name, what
 are they keeping from me?", @"
 1. Push through

 2. Turn back");
			prompt22 = new Prompt(@" I push the door op- wait a second… what am I doing? I was given the honor of a
 lifetime to serve my country... what am I doing snooping around these hallways? I
 should turn back and just go to sleep. But then again, this door says my name, what
 are they keeping from me?", @"
 1. Push through

 2. Turn back");
			prompt23 = new Prompt(@" What is going on?!?! What is compelling me to do this?” I look to my right... and
 in the dark... a face. Illuminated by a screen with words streaming by. I squint to get
 a better look. I see confusion in their face. My decisions haven’t been my own. Well
 I am done being someone else's puppet.", @"
 1. Close program");
			prompt24 = new Prompt(@"", @"");
			prompt25 = new Prompt(@" I float over to my pCom and send the message back to Ares that I’ve finally reached
 the object. It’ll take an hour for me to get their response, and I am only 45 minutes
 from the object. Guess I lost track of time day dreaming. I kill half an hour idly
 watching the radar sweep through nothingness. Then, slowly I watch the object take
 form on the monitor. But- the outline is changing. That can’t be possible, can it?
 Then I see that not only is it changing shape, but the object is moving towards me!
 I push to the bow window and my jaw drops. Just outside the window; something I
 can’t describe. Pulsating and smooth, alive. I don’t think it has eyes, but I feel it
 looking back at me. I am surrounded by a sense of calm, entranced by its indescribable
 colors.
 *Message incoming*

 Voice: “Kadar. This is Ares base. Do not, I repeat do not, get too close to that
 thing, we know all that we need to about it. Fire your weapons as soon as you are
 within range. Destroy the object”

 What? They couldn’t be serious! They must not realize whats out here. But orders are
 orders right? Maybe they do know best.
", @"
 1. Fire Weapon

 2. Disobey");
			prompt26 = new Prompt(@" I float over to my pCom and send the message back to Ares that I’ve finally reached
 the object. It’ll take an hour for me to get their response, and I am only 45 minutes
 from the object. Guess I lost track of time day dreaming. I kill half an hour idly
 watching the radar sweep through nothingness. Then, slowly I watch the object take
 form on the monitor. A small blip, moving tangentially through the solar system. Could
 this really be what all of Ares was worried about? Suddenly, the object fades off the
 radar and reappears with a new trajectory, headed straight for my ship! I push off to
 look through the port beam window and see a small reflective rectangle, lazily rotating.
 Its colors, uncomfortable hit my eyes. There is something unfamiliar about how the light
 reflects off its surface. The object is going to collide with the ship if I don’t do
 something.

 *Message incoming*

 Voice: “Kadar. This is Ares base. Do not, I repeat do not, get too close to that
 thing, we know all that we need to about it. Fire your weapons as soon as you are
 within range. Destroy the object”

 Something doesn’t sit right with me, why send me all this way to destroy this
 object? But orders are orders right? Maybe they do know best.
", @"
 1. Fire the weapon

 2. Disobey");
			prompt27 = new Prompt(@"", @"");
			prompt28 = new Prompt(@"", @"");
			prompt29 = new Prompt(@"", @"");
			prompt30 = new Prompt(@"", @"");
			prompt31 = new Prompt(@"", @"");

		}
		private void QBorder()
		{
			WriteLine("\n────────────────────────────────────────────────────────────────────────────────────────────────────");
		}
		public void TitleScreen()
		{
			//ForegroundColor = ConsoleColor.;
			//BackgroundColor = ConsoleColor.;
			//Clear();
			Write(@".....:.:.:....;;t%X@8888888@@888;%8X8S8:8t@@@8 ;t%%SX8X8S%:;;t;. X88t...............................
...::::::::::;;;%S@88888tX8@8..@88888@X % S8 8888888888 8888 8 8 @8S8;..............................
..::::::;;:::;t%X8888888@8888;X888S 8%88888888888888888@88 88888 8@%@X;.........:.:......:..........
.::;:;;;;;:;tt%888888@888X888SX 8 8 8888888888888@888888888888888 88S @....:..:::...::.:............
.:::;:;;;;;;tSS@8@88888t8@8X S %8888888888888@88X@888@888 @@88S8 8SS@S.@:.....:....::....::.::......
.:;;::;:;;;;tXS8@88S: 888X S  8888 88888888888888888888S88S88 8888 SSX88%..::.:..:...........:......
.::;::;;;;tt%X888@SS:888SS8 88888888888888@8888@8888 88888S8888888 8X88tX.::....::..:.::::..........
.:;;:;;;;tt%X8888@%.888X%SXS88888 8888888@@@88@ 888888888888@X8@8@888@X8t%..........:.......::......
.:;;:;;;;t%SSX88S; .888888888@SS8888S88X8XS8: 8%888888888X%88@@8X8888t@8SS....:..:..:::...:.........
.:;::::;;ttX%888@8X8:88St88@@S8@888 888@ 88@888@@888@88888888888888888X8:%::.::.:.:.....::..........
.::;;;;;t%t%S@@@8888XS8t8:t8 @88888@@X%S88888 8@@@888888888888X8SXX8@88. @.:..:.:.:::::.:...:.......

                    888888ba               88888888b       dP                   
                    88    `8b              88              88                   
                    88     88 .d8888b.    a88aaaa    .d888b88 .d8888b. .d8888b. 
                    88     88 88'  `88     88        88'  `88 88'  `88 88ooood8 
                    88     88 88.  .88     88        88.  .88 88.  .88 88.  ... 
                    dP     dP `88888P'     88888888P `88888P8 `8888P88 `88888P' 
                                                                   .88          
                                                               d8888P           
.:;;;t;;;;;;;tt%S@X8X88@XS888@tt8:X;8.S@S  X 8S 88 %@S8@8  8888@S :%t;:::::::::::::::::::...:.......
.::;;;;;;t;;tt;tt%X%8S8@S8X88@88.888@ 88 X% 888888888 X 88 @88: ;tXS::;:::::::::::::::::::::::.:::..
.:;;;;t;;;;t;;;tt%t%X8XX8@8888X%8888888X8@888.X88S88:t88@88  %SX8X;::::::::;::::::::::::::.:........
.:;;;t;tt;;;;;t;t%S@S8@@88@8@X8%%8888@888@88:@888@88888888 %X88@S;:::::::;:::::::::::::::..:..:.:...
::;;;;;;t;;;;;;ttt%tt;SS@X8S88@888@88@S88t8t8S888.88888;888888t%;::::::;::;::::::::::::::::...:.:...
::;;t;;;;;t;;;;;t;;%tXtt%XtX8@@888%@X8SXX8@S::;tS8;8888@888%t;;;;;:::::::::;:::::::::;:::.::..:.....
.:;;;;;;tt;;t;;:;;;tt;tt%t%t%8XSX88888888888888@888@888X%t;t;::;::::;:::::::;:::::::::::::::::...:..
.:;t;;t;ttt;;;;;;;;;;t;%t%%%StS@X@@@88@@88X8@88888S%8SSX;;;;:::::::::::::::::::::::::::::.::....::..
.;;;t;tt;;;t;;;;;tt;;t;ttt;t%%tttt%SS%SXt%Xt%S%SX%St;t;:;;:::::;:::::::;:::::::::::::::::::::..::...
.:;t;tt;t;t;;;;;;t;;ttt%;;;t;;;;tttt%%t;ttttt%%%tt:;;:;::::::;:;::;:;:::::::;:::::::::::::::...:....
");
			ReadKey();
			Clear();
			Intro();
		}
		private void Intro()
		{
			Write(@" I look out the shuttle window as the last speck of earth is enveloped by the black of
 space. Settling back into my seat I reread the email that I received what feels like
 days ago, but was in fact only 18 hours prior.");
			ForegroundColor = ConsoleColor.Blue;
			Write(@"

┌───────────────────────────────────────────────────────────────────────────────────────┐
│ Major Kadar,                                                                          │
│ You are to report to the Johnson Space Center immediately. Recent developments in the │
│ outer solar system have raised serious concerns for planet wide security. You will be │
│ briefed with further mission details once you land outside the Ares Space Force Base. │
│ Tell no one of your departure. This mission is in every sense, off the books.         │
│                                                                                       │
│ Edmond J. Shaw                                                                        │
│ Chief of Space Operations                                                             │
│ United Armed Forces                                                                   │
└───────────────────────────────────────────────────────────────────────────────────────┘");
			ForegroundColor = ConsoleColor.White;
			Write(@"

 The weight of my eyelids blur my vision as I read the last sentence. I nestle into the
 seat. I’m not sure if I’ll have time to sleep after I land on Mars.");
			ForegroundColor = ConsoleColor.Red;
			Write("\n\n Press any key to continue...");
			ReadKey();
			ForegroundColor = ConsoleColor.White;
			Clear();
			RunPrompt1();
		}
		private void RunPrompt1()
		{
			ForegroundColor = ConsoleColor.White;
			WriteLine(prompt1.Text);
			ForegroundColor = ConsoleColor.Blue;
			QBorder();
			ForegroundColor = ConsoleColor.Red;
			WriteLine(prompt1.Options);
			ForegroundColor = ConsoleColor.Blue;
			Write("\n I say: ");
			string prompt1input = "";
			prompt1input = ReadLine();
			if (prompt1input == "1")
			{
				CurrentPlayer.SeraRespect = CurrentPlayer.SeraRespect + 1;
				Clear();
				RunPrompt2();
			}
			if (prompt1input == "2")
			{
				CurrentPlayer.SeraRespect = CurrentPlayer.SeraRespect +1 ;
				Clear();
				RunPrompt3();
			}
			if (prompt1input == "3")
			{
				CurrentPlayer.SeraRespect = CurrentPlayer.SeraRespect - 1;
				Clear();
				RunPrompt4();
			}
			if (prompt1input == "4")
			{
				CurrentPlayer.SeraRespect = CurrentPlayer.SeraRespect - 1;
				Clear();
				RunPrompt5();
			}
			else
			{
				Clear();
				RunPrompt1();
			}
		}
		private void RunPrompt2()
		{
			ForegroundColor = ConsoleColor.White;
			WriteLine(prompt2.Text);
			ForegroundColor = ConsoleColor.Red;
			Write("\n Press any key to continue... ");
			ReadKey();
			Clear();
			RunPrompt6();
		}
		private void RunPrompt3()
		{
			ForegroundColor = ConsoleColor.White;
			WriteLine(prompt3.Text);
			ForegroundColor = ConsoleColor.Red;
			Write("\n Press any key to continue... ");
			ReadKey();
			Clear();
			RunPrompt6();
		}
		private void RunPrompt4()
		{
			ForegroundColor = ConsoleColor.White;
			WriteLine(prompt4.Text);
			ForegroundColor = ConsoleColor.Red;
			Write("\n Press any key to continue... ");
			ReadKey();
			Clear();
			RunPrompt6();
		}
		private void RunPrompt5()
		{
			ForegroundColor = ConsoleColor.White;
			WriteLine(prompt5.Text);
			ForegroundColor = ConsoleColor.Red;
			Write("\n Press any key to continue... ");
			ReadKey();
			Clear();
			RunPrompt6();
		}
		private void RunPrompt6()
		{
			ForegroundColor = ConsoleColor.White;
			WriteLine(prompt6.Text);
			ForegroundColor = ConsoleColor.Blue;
			QBorder();
			ForegroundColor = ConsoleColor.Red;
			WriteLine(prompt6.Options);
			ForegroundColor = ConsoleColor.Blue;
			Write("\n I say: ");
			string prompt6input = "";
			prompt6input = ReadLine();
			if (prompt6input == "1")
			{
				Clear();
				ForegroundColor = ConsoleColor.White;
				Write(@" Tali: “Straight to the point, I like that. I wish I had better news for you, but I
 don’t even know what the situation truly is. The most anyone knows is that there is a
 radio repeater coming from a stable orbit around Jupiter. No one has taken claim of it,
 and all the other space able countries are waiting to see our response. As of now it is
 considered a threat and most likely needs to be neutralized, especially in the event
 this is an extrasolar object.”");
				CurrentPlayer.TaliRespect = CurrentPlayer.TaliRespect + 1;
				ForegroundColor = ConsoleColor.Red;
				Write("\n\n Press any key to continue... ");
				ForegroundColor = ConsoleColor.White;
				ReadKey();
				Clear();
				RunPrompt7();
			}
			if (prompt6input == "2")
			{
				Clear();
				ForegroundColor = ConsoleColor.White;
				Write(@" Tali: “Not good. I have the collective fury of every member of the planetary defense
 council beating down my door asking what my boys in the intersolar department have found
 and I don't even know what to tell them. In short, that's why I’ve brought you here.
 There's an object orbiting Jupiter and we need you to figure out what it is, we’ve got
 every satellite we have pointed at it but with all the bloated bureaucracy around
 artificial rights, it will take twice as long to get a satellite up there than just
 sending you so that's what I’m doing. Sending you.”");
				ForegroundColor = ConsoleColor.Red;
				Write("\n\n Press any key to continue... ");
				ForegroundColor = ConsoleColor.White;
				ReadKey();
				Clear();
				RunPrompt7();

			}
			if (prompt6input == "3")
			{
				Clear();
				ForegroundColor = ConsoleColor.White;
				Write(@" Tali: You’ve got more attitude than you did when you were an applicant. I won’t take
 any more of your oh so precious time with the details then. The deal is you do what I say
 and what I say is that you’re going to Jupiter to investigate an unknown object. This base
 and the reputations of the nation’s space program is riding on this so don’t fuck it up.”");
				CurrentPlayer.TaliRespect = CurrentPlayer.TaliRespect - 2;
				ForegroundColor = ConsoleColor.Red;
				Write("\n\n Press any key to continue... ");
				ForegroundColor = ConsoleColor.White;
				ReadKey();
				Clear();
				RunPrompt8();
			}
			else
			{
				Clear();
				RunPrompt6();
			}
		}
		private void RunPrompt7()
		{
			ForegroundColor = ConsoleColor.White;
			WriteLine(prompt7.Text);
			ForegroundColor = ConsoleColor.Blue;
			QBorder();
			ForegroundColor = ConsoleColor.Red;
			WriteLine(prompt7.Options);
			ForegroundColor = ConsoleColor.Blue;
			Write("\n I say: ");
			string prompt7input = "";
			prompt7input = ReadLine();
			if (prompt7input == "1")
			{
				Clear();
				ForegroundColor = ConsoleColor.White;
				Write(@" Tali: “You have a background in exobio plus advanced piloting skill, and from what I
 understand, this isn’t your first black op.”");
				ForegroundColor = ConsoleColor.Red;
				Write("\n\n Press any key to continue... ");
				ForegroundColor = ConsoleColor.White;
				ReadKey();
				Clear();
				RunPrompt12();
			}
			if (prompt7input == "2")
			{
				if (CurrentPlayer.TaliRespect == 1)
				{
					CurrentPlayer.HasVisitorPass = true;
					Clear();
					ForegroundColor = ConsoleColor.White;
					Write(@" Tali: “That is all I know, but if you want to go to intersolar command and ask around,
 be my guess. Take this visitor pass, it’ll let you scan into the labs.”
 
 Tali presses a button on her desk.

 Tali: “Sera, please show Major Kadar to the intersolar command.”

 She releases her finger and raises from her desk. She opens the door.

 Tali: “Make your country proud, major.”

 Sera greets me and motions to follow her. I go down a hall and turn north to
 the command center. From there I turn right to intersolar command.

 Sera: “Here is the location of intersolar command. Feel free to come here once
 you are settled into your room”

 Sera turns south and leads me to my room. She smiles and motions to the door.");
					ForegroundColor = ConsoleColor.Red;
					Write("\n\n Press any key to continue... ");
					ForegroundColor = ConsoleColor.White;
					ReadKey();
					Clear();
					RunPrompt12();
				}
				else
				{
					Clear();
					ForegroundColor = ConsoleColor.White;
					Write(@"That's all I know.
 Tali presses a button on her desk.

 Tali: “Sera, please show Major Kadar his room.”

 She releases her finger and raises from her desk. She opens the door.

 Tali: “Make your country proud, major.”

 Sera greets me and motions to follow her to my room

 Sera: “Here's your room!”

 She smiles and motions to the door.");
					ForegroundColor = ConsoleColor.Red;
					Write("\n\n Press any key to continue... ");
					ForegroundColor = ConsoleColor.White;
					ReadKey();
					Clear();
					RunPrompt10();
				}
			}
			if (prompt7input == "3")
			{
				Clear();
				RunPrompt9();
			}
			else
			{
				Clear();
				RunPrompt7();
			}
		}
		private void RunPrompt8()
		{
			ForegroundColor = ConsoleColor.White;
			WriteLine(prompt8.Text);
			ForegroundColor = ConsoleColor.Blue;
			QBorder();
			ForegroundColor = ConsoleColor.Red;
			WriteLine(prompt8.Options);
			ForegroundColor = ConsoleColor.Blue;
			Write("\n I say: ");
			string prompt8input = "";
			prompt8input = ReadLine();
			ForegroundColor = ConsoleColor.White;
			if (prompt8input == "1")
			{
				CurrentPlayer.TaliRespect = CurrentPlayer.TaliRespect + 1;
				Clear();
				RunPrompt9();
			}
			if (prompt8input == "2")
			{
				CurrentPlayer.TaliRespect = CurrentPlayer.TaliRespect - 1;
				Clear();
				RunPrompt9();
			}
			else
			{
				Clear();
				RunPrompt8();
			}
		}
		private void RunPrompt9()
		{
			ForegroundColor = ConsoleColor.White;
			WriteLine(prompt9.Text);
			ForegroundColor = ConsoleColor.Red;
			Write(" Press any key to continue... ");
			ReadKey();
			if (CurrentPlayer.SeraRespect == 1)
			{
				Clear();
				RunPrompt11();
			}
			else
			{
				Clear();
				RunPrompt10();
			}
		}
		private void RunPrompt10()
		{
			ForegroundColor = ConsoleColor.White;
			WriteLine(prompt10.Text);
			ForegroundColor = ConsoleColor.Blue;
			QBorder();
			ForegroundColor = ConsoleColor.Red;
			WriteLine(prompt10.Options);
			ForegroundColor = ConsoleColor.Blue;
			Write("\n I say: ");
			string prompt10input = "";
			prompt10input = ReadLine();
			ForegroundColor = ConsoleColor.White;
			if (prompt10input == "1")
			{
				Clear();
				RunPrompt14();
			}
			if (prompt10input == "2")
			{
				Clear();
				RunPrompt15();
			}
			else
			{
				Clear();
				RunPrompt10();
			}
		}
		private void RunPrompt11()
		{
			ForegroundColor = ConsoleColor.White;
			WriteLine(prompt11.Text);
			ForegroundColor = ConsoleColor.Blue;
			QBorder();
			ForegroundColor = ConsoleColor.Red;
			WriteLine(prompt11.Options);
			ForegroundColor = ConsoleColor.Blue;
			Write("\n I say: ");
			string prompt11input = "";
			prompt11input = ReadLine();
			ForegroundColor = ConsoleColor.White;
			if (prompt11input == "1")
			{
				Clear();
				Write(@" Sera: “Just make you’re on time for launch”

 Sera smiles.

 Sera: “And make sure you get a good night's sleep tonight.”");
				ForegroundColor = ConsoleColor.Red;
				Write("\n\n Press any key to continue...");
				ReadKey();
				Clear();
				RunPrompt10();
			}
			if (prompt11input == "2")
			{
				Clear();
				RunPrompt13();
			}
			if (prompt11input == "3")
			{
				Clear();
				RunPrompt13();
			}
			else
			{
				Clear();
				RunPrompt11();
			}

		}
		private void RunPrompt12()
		{
			Write(@" Tali: “Getting cold feet Kadar?”

 Kadar: “No, I’m honored ma’am. I just want to make sure that I prepared for the mission at hand.”

 Tali gives me a reassuring smile.

 Tali: “I wouldn’t have flown you out here if I didn’t think you were the best person for the job.”

 The director paused for a moment and then...");
			ForegroundColor = ConsoleColor.Red;
			Write("\n\n Press any key to continue... ");
			ReadKey();
			ForegroundColor = ConsoleColor.White;
			Clear();
			RunPrompt9();
		}
		private void RunPrompt13()
		{
			Write(@" Sera: “Look, Tali doesn’t think I see the things that go on here but of course I do,
 I’ve lived here for the better half of a decade now.”

 She looks sharply up at a security camera in the ceiling a few meters away. She grabs
 a pen from her side pocket and writes two words on my hand. It says “Hermes Deep");
			CurrentPlayer.Hermes = true;
			ForegroundColor = ConsoleColor.Red;
			Write("\n\n Press any key to continue...");
			ReadKey();
			Clear();
			ForegroundColor = ConsoleColor.White;
			RunPrompt10();
		}
		public void RunPrompt14()
		{
			Write(@" I look in the closet at the clothes they prepared for me and change into the pajamas.
 I brush my teeth and look into the mirror. “Better enjoy tonight” I think to myself,
 “last night sleeping with gravity.” I spit into the sink and shuffle to the bed, sink
 into the mattress and begin to dream…

 I’m floating through rings of ice and crystal, like pieces of mirrors reflecting
 billions of beams of light back into the dark. An endless waterfall of every chemistry,
 shimmering for no one, no one but me. For a moment I forget where I am.


 The weak beep of some speaker pulls me back to reality. Inside a tin can headed to
 Jupiter, a top-secret mission, for my eyes only, mine and the hundred of scientists
 back on mars waiting to see what I find. Today is the day though.After weeks alone I’ll
 finally know what this whole mission is about.

 The beep was coming from the radar, the unidentified object is within range.
");
			ForegroundColor = ConsoleColor.Red;
			Write("\n\n Press any key to continue...");
			ReadKey();
			Clear();
			ForegroundColor = ConsoleColor.White;
			Random rnd = new Random();
			int ending = rnd.Next(1, 4);
			if (CurrentPlayer.Inter == true)
			{
				Clear();
				RunPrompt25();
			}
			if (CurrentPlayer.Extra == true)
			{
				Clear();
				RunPrompt26();
			}
			if (ending == 1)
			{
				Clear();
				RunPrompt25();
			}
			if (ending == 2)
			{
				Clear();
				RunPrompt26();
			}
			if (ending == 3)
			{
				Clear();
				RunPrompt27();
			}

		}
		private void RunPrompt15()
		{
			ForegroundColor = ConsoleColor.White;
			WriteLine(prompt15.Text);
			ForegroundColor = ConsoleColor.Blue;
			QBorder();
			ForegroundColor = ConsoleColor.Red;
			WriteLine(prompt15.Options);
			ForegroundColor = ConsoleColor.Blue;
			Write("\n I inspect: ");
			ForegroundColor = ConsoleColor.White;
			string prompt15input = "";
			prompt15input = ReadLine();
			if (prompt15input == "1")
			{
				Clear();
				RunPrompt16();
			}
			if (prompt15input == "2")
			{
				CurrentPlayer.Extra = true;
				Clear();
				RunPrompt17();
			}
			if (prompt15input == "3")
			{
				Clear();
				RunPrompt18();
			}
			else
			{
				Clear();
				RunPrompt15();
			}
		}
		private void RunPrompt16()
		{
			if (CurrentPlayer.HasVisitorPass == true)
			{
				CurrentPlayer.Inter = true;
				Clear();
				Write(@" *BEEP* the door opens with my pass and a smiling scientist greets me with a firm
 handshake. His thin stature exaggerates his already great height which is topped
 with a lopsided grin. He tells me his name is Westlyn and we walk through rows of
 workbenches while he gives an obviously very practiced speech about what they do
 in this lab. Before I can even ask any questions he is leading me out the door and
 back to my room. They obviously want to keep me in the dark but why? I shake the
 feeling and shamble back to my quarters. Time for bed.");
				ForegroundColor = ConsoleColor.Red;
				Write("\n\n Press any key to continue...");
				ReadKey();
				Clear();
				ForegroundColor = ConsoleColor.White;
				RunPrompt14();
			}
			if (CurrentPlayer.HasVisitorPass == false)
			{
				Write(@" Just as I approach the lab, an abnormally tall man enters the hall and briskly
 walks the other direction. Quickly I slide through the door before it closes. There
 are rows of desks covered with papers and half-built sensors. After 15 minutes of
 snooping I reach a desk against the far wall with a name plate reading “Westlyn”.
 Must have been Westlyn that walked out as I came in because it is the only computer
 that hasn’t timed out. I search my name in his email and find a chain titled “Sample
 retrieval of Jovizoa”. The last email in the chain reads:");
				ForegroundColor = ConsoleColor.Blue;
				Write(@"

┌──────────────────────────────────────────────────────────────────────────────────────┐
│ Hello Tali,                                                                          │
│                                                                                      │
│ No, I really don’t think Kadar should be let in on the final goal of this mission. I │
│ still think we should have gone with the military guys, you’ve seen how trigger happy│
│ they are, plus they won’t question the final order. But I know the ship already left │
│ JSC so no use in complaining about it now.                                           │
│                                                                                      │
│ Westlyn                                                                              │
│                                                                                      │
│ Director of Intersolar Command                                                       │
└──────────────────────────────────────────────────────────────────────────────────────┘");
				ForegroundColor = ConsoleColor.White;
				Write(@"

 Just as I finish reading, I hear talking in the hallway. Suppose I should be getting
 back to my room before anyone notices I am gone. After making sure no one is in the
 hall, I open the door and head back to my quarters.");
				ForegroundColor = ConsoleColor.Red;
				Write("\n\n Press any key to continue...");
				ReadKey();
				Clear();
				ForegroundColor = ConsoleColor.White;
				RunPrompt14();
			}
		}
		private void RunPrompt17()
		{
			Write(@" I walk up to the door marked 'Extrasolar command' and press the button to open the
 lab. Surprisingly it opens, someone left the door open when they left for the evening.
 Spread across every desk are schematics of some space craft called 'Hermes Deep', but
 why would extrasolar command be building a probe? As far as I know they only work with
 data from outside the solar system. Before I can take a closer look, a tall thin man
 with an uneven frown coughs to get my attention.

 Man: “Excuse me Kadar, I do believe you should be getting some rest before your big
 mission, no?”

 I mumble something under my breath and follow him back to my room.");
			ForegroundColor = ConsoleColor.Red;
			Write("\n\n Press any key to continue...");
			ReadKey();
			Clear();
			ForegroundColor = ConsoleColor.White;
			RunPrompt14();
		}
		private void RunPrompt18()
		{
			ForegroundColor = ConsoleColor.White;
			WriteLine(prompt18.Text);
			ForegroundColor = ConsoleColor.Blue;
			QBorder();
			ForegroundColor = ConsoleColor.Red;
			WriteLine(prompt18.Options);
			ForegroundColor = ConsoleColor.Blue;
			Write("\n I: ");
			string prompt18input = "";
			prompt18input = ReadLine();
			ForegroundColor = ConsoleColor.White;
			if (prompt18input == "1")
			{
				Clear();
				RunPrompt19();
			}
			if (prompt18input == "2")
			{
				Clear();
				RunPrompt24();
			}
			else
			{
				Clear();
				RunPrompt18();
			}
		}
		private void RunPrompt19()
		{
			ForegroundColor = ConsoleColor.White;
			WriteLine(prompt19.Text);
			ForegroundColor = ConsoleColor.Blue;
			QBorder();
			ForegroundColor = ConsoleColor.Red;
			WriteLine(prompt19.Options);
			ForegroundColor = ConsoleColor.Blue;
			Write("\n I: ");
			string prompt19input = "";
			prompt19input = ReadLine();
			ForegroundColor = ConsoleColor.White;
			if (prompt19input == "1")
			{
				Clear();
				RunPrompt20();
			}
			if (prompt19input == "2")
			{
				Clear();
				RunPrompt24();
			}
			else
			{
				Clear();
				RunPrompt19();
			}
		}
		private void RunPrompt20()
		{
			ForegroundColor = ConsoleColor.White;
			WriteLine(prompt20.Text);
			ForegroundColor = ConsoleColor.Blue;
			QBorder();
			ForegroundColor = ConsoleColor.Red;
			WriteLine(prompt20.Options);
			ForegroundColor = ConsoleColor.Blue;
			Write("\n I: ");
			string prompt20input = "";
			prompt20input = ReadLine();
			ForegroundColor = ConsoleColor.White;
			if (prompt20input == "1")
			{
				Clear();
				RunPrompt21();
			}
			if (prompt20input == "2")
			{
				Clear();
				RunPrompt24();
			}
			else
			{
				Clear();
				RunPrompt20();
			}
		}
		private void RunPrompt21()
		{
			ForegroundColor = ConsoleColor.White;
			WriteLine(prompt21.Text);
			ForegroundColor = ConsoleColor.Blue;
			QBorder();
			ForegroundColor = ConsoleColor.Red;
			WriteLine(prompt21.Options);
			ForegroundColor = ConsoleColor.Blue;
			Write("\n I: ");
			string prompt21input = "";
			prompt21input = ReadLine();
			ForegroundColor = ConsoleColor.White;
			if (prompt21input == "1")
			{
				Clear();
				RunPrompt22();
			}
			if (prompt21input == "2")
			{
				Clear();
				RunPrompt24();
			}
			else
			{
				Clear();
				RunPrompt21();
			}
		}
		private void RunPrompt22()
		{
			ForegroundColor = ConsoleColor.White;
			WriteLine(prompt22.Text);
			ForegroundColor = ConsoleColor.Blue;
			QBorder();
			ForegroundColor = ConsoleColor.Red;
			WriteLine(prompt22.Options);
			ForegroundColor = ConsoleColor.Blue;
			Write("\n I: ");
			string prompt22input = "";
			prompt22input = ReadLine();
			ForegroundColor = ConsoleColor.White;
			if (prompt22input == "1")
			{
				Clear();
				RunPrompt23();
			}
			if (prompt22input == "2")
			{
				Clear();
				RunPrompt24();
			}
			else
			{
				Clear();
				RunPrompt23();
			}
		}
		private void RunPrompt23()
		{
			ForegroundColor = ConsoleColor.White;
			WriteLine(prompt23.Text);
			ForegroundColor = ConsoleColor.Blue;
			QBorder();
			ForegroundColor = ConsoleColor.Red;
			WriteLine(prompt23.Options);
			ForegroundColor = ConsoleColor.Blue;
			Write("\n I: ");
			string prompt23input = "";
			prompt23input = ReadLine();
			ForegroundColor = ConsoleColor.White;
			if (prompt23input == "1")
			{
			}
			else
			{
				Clear();
				RunPrompt23();
			}
		}
		private void RunPrompt24()
		{
			Write(@" I can’t deal with all this existential crap right now; I have a mission to do. What
 I need to do is clear my mind and go to sleep.");
			ForegroundColor = ConsoleColor.Red;
			Write("\n\n Press any key to continue...");
			ReadKey();
			Clear();
			ForegroundColor = ConsoleColor.White;
			RunPrompt14();
		}
		private void RunPrompt25()
		{
			ForegroundColor = ConsoleColor.White;
			WriteLine(prompt25.Text);
			ForegroundColor = ConsoleColor.Blue;
			QBorder();
			ForegroundColor = ConsoleColor.Red;
			WriteLine(prompt25.Options);
			ForegroundColor = ConsoleColor.Blue;
			Write("\n I: ");
			string prompt25input = "";
			prompt25input = ReadLine();
			ForegroundColor = ConsoleColor.White;
			if (prompt25input == "1")
			{
				Clear();
				RunPrompt28();
			}
			if (prompt25input == "2")
			{
				Clear();
				RunPrompt29();
			}
			else
			{
				Clear();
				RunPrompt25();
			}
		}
		private void RunPrompt26()
		{
			ForegroundColor = ConsoleColor.White;
			WriteLine(prompt26.Text);
			ForegroundColor = ConsoleColor.Blue;
			QBorder();
			ForegroundColor = ConsoleColor.Red;
			WriteLine(prompt26.Options);
			ForegroundColor = ConsoleColor.Blue;
			Write("\n I: ");
			string prompt26input = "";
			prompt26input = ReadLine();
			ForegroundColor = ConsoleColor.White;
			if (prompt26input == "1")
			{
				Clear();
				RunPrompt30();
			}
			if (prompt26input == "2")
			{
				Clear();
				RunPrompt31();
			}
			else
			{
				Clear();
				RunPrompt26();
			}
		}
		private void RunPrompt27()
		{
			Write(@" I float over to my pCom and send the message back to Ares that I’ve finally reached
 the object. It’ll take an hour for me to get their response, and I am only 45 minutes
 from the object. Guess I lost track of time day dreaming. I kill half an hour idly
 watching the radar sweep through nothingness. Then suddenly a red light fills the
 cabin.
 
 *ALERT. ALERT. PRIMARY AND SECONDARY POWER FAILURE. ALL CONTROLS SWITCHED TO MANUAL.*
 
 For a moment I panic and look around to see my options but pretty soon it sets in that
 there is nothing I can do. I feel the pull of Jupiter arc my ships trajectory towards
 its looming horizon. 

 Its sunset on the red giant and golden rays penetrate the thick clouds of yellow and
 orange. Before long Jupiter will pull me into its depths, a view no human has even
 seen so I curl up in the viewing pod and settle in for this final spectacle.Wisps of
 gas fly by my window with a deafening sound. I can see storms in the distance,
 endlessly swirling.Even now, before my ship has passed the surface, I can feel the
 stress of the pressure on the hull. Here in Jupiter, time lost the little meaning it
 ever had in space.Almost imperceptibly, the sun fades out of view and I see flashes
 of purple light illuminating patches of cloud. Lightning and thunder shake my ship.
 Folds start to form along the walls and windows. I close my eyes and fall into the
 darkness.
");
			ForegroundColor = ConsoleColor.Red;
			Write("\n Press any key to exit the program... ");
			ReadKey();
			Environment.Exit(0);
		}
		private void RunPrompt28()
		{
			Write(@" I look back to the weapons panel. I know what I must do. I lock my feet to the floor
 and resign myself to the task at hand.

 *Target locked. Confirm selection?*

 I look one last time out the window. The first and last person to see this cosmic
 beast. I can’t watch. I look at the monitor and select confirm. A soft hum as the
 weapons fire. I message Ares that the mission was a success. For the first time 
 space feels lonely. I push to my sleeping bag and curl up for the long quite ride 
 home.");
			ForegroundColor = ConsoleColor.Red;
			Write("\n\n Press any key to exit the program... ");
			ReadKey();
			Environment.Exit(0);
		}
		private void RunPrompt29()
		{
			Write(@" Fuck this. I am not a murderer, and first contact isn’t going to be first blood. I
 tell the computer to fire four units left of the creature. The creature turns a
 ghostly pale and turns to fall toward Jupiter. I watch as it pulsates into the murky
 depths of orange clouds. I message Ares that the mission was a success. 

 Eventually the higher ups will figure out what went happened here today, but I will
 deal with that when it comes. I set course back for home, feeling a warmth in my chest
 knowing the big black is a little less lonely.
");
			ForegroundColor = ConsoleColor.Red;
			Write("\n\n Press any key to exit the program... ");
			ReadKey();
			Environment.Exit(0);
		}
		private void RunPrompt30()
		{
			Write(@" Well orders are orders. I lock my feet to the floor and plug in the coordinates of
 the object. *Target locked. Confirm selection? * One last look out object right as
 it becomes an eruption of iridescent gold and silver. Maybe someone knows what
 happened here today, but I don’t. Just playing my part in the larger political
 machine. The long ride home felt shorter than most. The next few days were a blur
 of NDAs and debriefs, handshakes and Thank you Sir’s. Eventually it ends with me
 back on Earth. I spend my days, lost in misplaced nostalgia and contemplations of
 our collective concessions.");
			ForegroundColor = ConsoleColor.Red;
			Write("\n\n Press any key to exit the program... ");
			ReadKey();
			Environment.Exit(0);
		}
		private void RunPrompt31()
		{
			Write(@" I have to know, for me. I float over to the HAB arm control and plug in the coordinates
 of the object.

 *Target locked. Confirm selection?*

 No going back now.

 *Confirm*

 The arm slowly reaches out and secures the vitreous object from the pool of surrounding
 black. The hiss of the airlock ends, and I eagerly open the door. The object, the
 satellite, is like nothing I have ever seen before. Without thinking I put my hands
 on the object. Its a capsule of some kind, and inside it, a small cube. Writings,
 drawings, and diagrams like I have never seen before.

 This greeting from the stars, a message in the bottle, from a civilization unlike our
 own. We have never detected any signals from another intelligent species, and this
 object was moving much slower that the speed of light so it must be at least millions,
 if not billions of years old, unrevenged by the teeth of time. Our first and last
 contact.
");
			ForegroundColor = ConsoleColor.Red;
			Write("\n\n Press any key to exit the program... ");
			ReadKey();
			Environment.Exit(0);
		}
	}
}
