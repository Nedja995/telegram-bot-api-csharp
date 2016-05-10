namespace Telebot.Objects
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    [JsonObject("User")]
    public class User
    {
        [JsonProperty("id")]
        public string id;
        [JsonProperty("first_name")]
        public string first_name;
        [JsonProperty("username")]
        public string username;
    }
    [JsonObject("getMe")]
    public class getMe
    {
        [JsonProperty("ok")]
        public bool ok;

        [JsonProperty("result")]
        public User result;
    }
    [JsonObject("Chat")]
    public class Chat
    {
        [JsonProperty("id")]
        public int id;
        [JsonProperty("type")]
        public string type;
        [JsonProperty("title")]
        public string title;
        [JsonProperty("username")]
        public string username;
        [JsonProperty("first_name")]
        public string first_name;
        [JsonProperty("last_name")]
        public string last_name;
    }
    [JsonObject("MessageEntity")]
    public class MessageEntity{
        [JsonProperty("type")]
        public string type;
        [JsonProperty("offset")]
        public int offset;
        [JsonProperty("length")]
        public int length;
        [JsonProperty("url")]
        public string url;
    }
    [JsonObject("Message")]
    public class Message
    {
        [JsonProperty("message_id")]
        public int message_id;
        [JsonProperty("from")]
        public User from;
        [JsonProperty("date")]
        public int date;
        [JsonProperty("chat")]
        public Chat chat;
        [JsonProperty("forward_from")]
        public User forward_from;
        [JsonProperty("forward_from_chat")]
        public Chat forward_from_chat;
        [JsonProperty("forward_date")]
        public int forward_date;
        [JsonProperty("reply_to_message")]
        public Message reply_to_message;
        [JsonProperty("text")]
        public string text;
        [JsonProperty("entities")]
        public List<MessageEntity> entities;
        [JsonProperty("audio")]
        public Audio audio;
        [JsonProperty("document")]
        public Document document;
        [JsonProperty("photo")]
        public List<PhotoSize> photo;
        [JsonProperty("sticker")]
        public Sticker sticker;
        [JsonProperty("video")]
        public Video video;
        [JsonProperty("voice")]
        public Voice voice;
        [JsonProperty("caption")]
        public string caption;
        [JsonProperty("contact")]
        public string contact;
        [JsonProperty("location")]
        public Location location;
        [JsonProperty("venue")]
        public Venue venue;
        [JsonProperty("new_chat_member")]
        public User new_chat_member;
        [JsonProperty("left_chat_member")]
        public User left_chat_member;
        [JsonProperty("new_chat_title")]
        public string new_chat_title;
        [JsonProperty("new_chat_photo")]
        public List<PhotoSize> new_chat_photo;
        [JsonProperty("delete_chat_photo")]
        public bool delete_chat_photo;
        [JsonProperty("group_chat_created")]
        public bool group_chat_created;
        [JsonProperty("supergroup_chat_created")]
        public bool supergroup_chat_created;
        [JsonProperty("channel_chat_created")]
        public bool channel_chat_created;
        [JsonProperty("pinned_message")]
        public Message pinned_message;
    }
    [JsonObject("Update")]
    public class Update
    {
        [JsonProperty("update_id")]
        public int update_id;
        [JsonProperty("message")]
        public Message message;
        [JsonProperty("inline_query")]
        public InlineQuery inline_query;
        [JsonProperty("chosen_inline_result")]
        public ChosenInlineResult chosen_inline_result;
        [JsonProperty("callback_query")]
        public CallbackQuery callback_query;
    }
    [JsonObject("Audio")]
    public class Audio
    {
        [JsonProperty("file_id")]
        public string file_id;
        [JsonProperty("duration")]
        public int duration;
        [JsonProperty("performer")]
        public string performer;
        [JsonProperty("title")]
        public string title;
        [JsonProperty("mime_type")]
        public string mime_type;
        [JsonProperty("file_size")]
        public int file_size;
    }
    [JsonObject("Contact")]
    public class Contact
    {
        [JsonProperty("phone_number")]
        public string phone_number;
        [JsonProperty("first_name")]
        public string first_name;
        [JsonProperty("last_name")]
        public string last_name;
        [JsonProperty("user_id")]
        public int user_id;
    }
    [JsonObject("InlineQuery")]
    public class InlineQuery
    {
        [JsonProperty("id")]
        public string id;
        [JsonProperty("from")]
        public User from;
        [JsonProperty("location")]
        public Location location;
        [JsonProperty("query")]
        public string query;
        [JsonProperty("offset")]
        public string offset;
    }
    [JsonObject("ChosenInlineResult")]
    public class ChosenInlineResult
    {
        [JsonProperty("result_id")]
        public string result_id;
        [JsonProperty("from")]
        public User from;
        [JsonProperty("location")]
        public Location location;
        [JsonProperty("inline_message_id")]
        public string inline_message_id;
        [JsonProperty("query")]
        public string query;
    }
    [JsonObject("CallbackQuery")]
    public class CallbackQuery
    {
        [JsonProperty("id")]
        public string id;
        [JsonProperty("from")]
        public User from;
        [JsonProperty("message")]
        public Message message;
        [JsonProperty("inline_message_id")]
        public string inline_message_id;
        [JsonProperty("data")]
        public string data;
    }
    [JsonObject("Venue")]
    public class Venue
    {
        [JsonProperty("location")]
        public Location location;
        [JsonProperty("title")]
        public string title;
        [JsonProperty("address")]
        public string address;
        [JsonProperty("foursquare_id")]
        public string foursquare_id;
    }
    [JsonObject("Location")]
    public class Location
    {
        [JsonProperty("longitude")]
        public float longitude;
        [JsonProperty("latitude")]
        public float latitude;
    }
    [JsonObject("Voice")]
    public class Voice
    {
        [JsonProperty("file_id")]
        public string file_id;
        [JsonProperty("duration")]
        public int duration;
        [JsonProperty("mime_type")]
        public string mime_type;
        [JsonProperty("file_size")]
        public int file_size;
    }
    public class PhotoSize
    {
        [JsonProperty("file_id")]
        public string file_id;
        [JsonProperty("width")]
        public int width;
        [JsonProperty("height")]
        public int height;
        [JsonProperty("file_size")]
        public int file_size;
    }
    public class Sticker
    {
        [JsonProperty("file_id")]
        public string file_id;
        [JsonProperty("width")]
        public int width;
        [JsonProperty("height")]
        public int height;
        [JsonProperty("thumb")]
        public PhotoSize thumb;
        [JsonProperty("emoji")]
        public string emoji;
        [JsonProperty("file_size")]
        public int file_size;
    }
    [JsonObject("Video")]
    public class Video
    {
        [JsonProperty("file_id")]
        public string file_id;
        [JsonProperty("width")]
        public int width;
        [JsonProperty("height")]
        public int height;
        [JsonProperty("duration")]
        public int duration;
        [JsonProperty("thumb")]
        public PhotoSize thumb;
        [JsonProperty("mime_type")]
        public string mime_type;
        [JsonProperty("file_size")]
        public int file_size;
    }
    [JsonObject("Document")]
    public class Document
    {
        [JsonProperty("file_id")]
        public string file_id;
        [JsonProperty("thumb")]
        public PhotoSize thumb;
        [JsonProperty("file_name")]
        public string file_name;
        [JsonProperty("mime_type")]
        public string mime_type;
        [JsonProperty("file_size")]
        public int file_size;
    }
}
