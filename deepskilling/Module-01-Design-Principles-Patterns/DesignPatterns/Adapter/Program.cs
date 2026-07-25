using System;

interface IMediaPlayer
{
    void Play(string audioType, string fileName);
}

class AdvancedMediaPlayer
{
    public void PlayMp4(string fileName)
    {
        Console.WriteLine("Playing MP4 file: " + fileName);
    }
}

class MediaAdapter : IMediaPlayer
{
    private AdvancedMediaPlayer advancedPlayer;

    public MediaAdapter()
    {
        advancedPlayer = new AdvancedMediaPlayer();
    }

    public void Play(string audioType, string fileName)
    {
        if (audioType.Equals("mp4"))
        {
            advancedPlayer.PlayMp4(fileName);
        }
    }
}

class AudioPlayer : IMediaPlayer
{
    private MediaAdapter adapter;

    public void Play(string audioType, string fileName)
    {
        if (audioType.Equals("mp3"))
        {
            Console.WriteLine("Playing MP3 file: " + fileName);
        }
        else if (audioType.Equals("mp4"))
        {
            adapter = new MediaAdapter();
            adapter.Play(audioType, fileName);
        }
    }
}

class Program
{
    static void Main()
    {
        AudioPlayer player = new AudioPlayer();

        player.Play("mp3", "song.mp3");
        player.Play("mp4", "video.mp4");
    }
}