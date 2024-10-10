using System;

class Program
{
    static void Main(string[] args)
    {   // creating an instance of the screen class
        Screen screen = new Screen();
        
        //creating the instance of the first video 
        Video video1 = new Video();
        video1._title = "The biggest swimming pool in south america.";
        video1._author = "Water Adventures Channel.";
        video1._length = 180;

        // creating the comments for video 1
        Comment comment1 = new Comment();
        comment1._name = "Bruno Alves";
        comment1._commentText = "I love how the the dog jumps into the swimming pool.";
        video1._comments.Add(comment1);



        Comment comment2 = new Comment();
        comment2._name = "Thamara Egidio";
        comment2._commentText = "I wish I could take some pictures in that place.";
        video1._comments.Add(comment2);


        Comment comment3 = new Comment();
        comment3._name = "Tigrinho";
        comment3._commentText = "That guy on the red shirt is so funny.";
        video1._comments.Add(comment3);

        //adding the instance video1 into the videos list in the screen class
        screen._videos.Add(video1);




        //creating an instance of video 2
        Video video2 = new Video();
        video2._title = "Tiger hunting.";
        video2._author = "Tiger Home";
        video2._length = 135;
        
        //Creating the comments for the second video
        Comment comment4 = new Comment();
        comment4._name = "Carlos Pereira";
        comment4._commentText = "I'm always amazed at how strong tigers are.";
        video2._comments.Add(comment4);


        Comment comment5 = new Comment();
        comment5._name = "Flemio Correia";
        comment5._commentText = "that's so dope dude!";
        video2._comments.Add(comment5);


        Comment comment6 = new Comment();
        comment6._name = "Marta dos Santos";
        comment6._commentText = "Horrible scene";
        video2._comments.Add(comment6);


        //adding the instance video2 into the videos list in the screen class
        screen._videos.Add(video2);





        //creating an instance of video 3
        Video video3 = new Video();
        video3._title = "Aeroplane Takeoff";
        video3._author = "Cine Aviation";
        video3._length = 250;
        
        //Creating the comments for the second video
        Comment comment7 = new Comment();
        comment7._name = "Lito";
        comment7._commentText = "Aviation is safe.";
        video3._comments.Add(comment7);


        Comment comment8 = new Comment();
        comment8._name = "Ana Carolina";
        comment8._commentText = "I want to be a pilot someday";
        video3._comments.Add(comment8);


        Comment comment9 = new Comment();
        comment9._name = "Ronaldo";
        comment9._commentText = "I'm so afraid of aeroplanes, I only fly when it is extremely necessary";
        video3._comments.Add(comment9);


        //adding the instance video2 into the videos list in the screen class
        screen._videos.Add(video3);


        // display everything
        screen.DisplayScreen();
    }
}