using System.Text.Json.Serialization;

namespace GiphyIntegration.Api.Response
{
    public class GiphyResponse
    {
        [JsonPropertyName("data")]
        public List<Data> data { get; set; }

        [JsonPropertyName("pagination")]
        public Pagination pagination { get; set; }

        [JsonPropertyName("meta")]
        public Meta meta { get; set; }
    }

    public class _480wStill
    {
        [JsonPropertyName("height")]
        public string height { get; set; }

        [JsonPropertyName("width")]
        public string width { get; set; }

        [JsonPropertyName("size")]
        public string size { get; set; }

        [JsonPropertyName("url")]
        public string url { get; set; }
    }

    public class Analytics
    {
        [JsonPropertyName("onload")]
        public Onload onload { get; set; }

        [JsonPropertyName("onclick")]
        public Onclick onclick { get; set; }

        [JsonPropertyName("onsent")]
        public Onsent onsent { get; set; }
    }

    public class Data
    {
        [JsonPropertyName("type")]
        public string type { get; set; }

        [JsonPropertyName("id")]
        public string id { get; set; }

        [JsonPropertyName("url")]
        public string url { get; set; }

        [JsonPropertyName("slug")]
        public string slug { get; set; }

        [JsonPropertyName("bitly_gif_url")]
        public string bitly_gif_url { get; set; }

        [JsonPropertyName("bitly_url")]
        public string bitly_url { get; set; }

        [JsonPropertyName("embed_url")]
        public string embed_url { get; set; }

        [JsonPropertyName("username")]
        public string username { get; set; }

        [JsonPropertyName("source")]
        public string source { get; set; }

        [JsonPropertyName("title")]
        public string title { get; set; }

        [JsonPropertyName("rating")]
        public string rating { get; set; }

        [JsonPropertyName("content_url")]
        public string content_url { get; set; }

        [JsonPropertyName("source_tld")]
        public string source_tld { get; set; }

        [JsonPropertyName("source_post_url")]
        public string source_post_url { get; set; }

        [JsonPropertyName("is_sticker")]
        public int is_sticker { get; set; }

        [JsonPropertyName("import_datetime")]
        public string import_datetime { get; set; }

        [JsonPropertyName("trending_datetime")]
        public string trending_datetime { get; set; }

        [JsonPropertyName("images")]
        public Images images { get; set; }

        [JsonPropertyName("user")]
        public User user { get; set; }

        [JsonPropertyName("analytics_response_payload")]
        public string analytics_response_payload { get; set; }

        [JsonPropertyName("analytics")]
        public Analytics analytics { get; set; }
    }

    public class Downsized
    {
        [JsonPropertyName("height")]
        public string height { get; set; }

        [JsonPropertyName("width")]
        public string width { get; set; }

        [JsonPropertyName("size")]
        public string size { get; set; }

        [JsonPropertyName("url")]
        public string url { get; set; }
    }

    public class DownsizedLarge
    {
        [JsonPropertyName("height")]
        public string height { get; set; }

        [JsonPropertyName("width")]
        public string width { get; set; }

        [JsonPropertyName("size")]
        public string size { get; set; }

        [JsonPropertyName("url")]
        public string url { get; set; }
    }

    public class DownsizedMedium
    {
        [JsonPropertyName("height")]
        public string height { get; set; }

        [JsonPropertyName("width")]
        public string width { get; set; }

        [JsonPropertyName("size")]
        public string size { get; set; }

        [JsonPropertyName("url")]
        public string url { get; set; }
    }

    public class DownsizedSmall
    {
        [JsonPropertyName("height")]
        public string height { get; set; }

        [JsonPropertyName("width")]
        public string width { get; set; }

        [JsonPropertyName("mp4_size")]
        public string mp4_size { get; set; }

        [JsonPropertyName("mp4")]
        public string mp4 { get; set; }
    }

    public class DownsizedStill
    {
        [JsonPropertyName("height")]
        public string height { get; set; }

        [JsonPropertyName("width")]
        public string width { get; set; }

        [JsonPropertyName("size")]
        public string size { get; set; }

        [JsonPropertyName("url")]
        public string url { get; set; }
    }

    public class FixedHeight
    {
        [JsonPropertyName("height")]
        public string height { get; set; }

        [JsonPropertyName("width")]
        public string width { get; set; }

        [JsonPropertyName("size")]
        public string size { get; set; }

        [JsonPropertyName("url")]
        public string url { get; set; }

        [JsonPropertyName("mp4_size")]
        public string mp4_size { get; set; }

        [JsonPropertyName("mp4")]
        public string mp4 { get; set; }

        [JsonPropertyName("webp_size")]
        public string webp_size { get; set; }

        [JsonPropertyName("webp")]
        public string webp { get; set; }
    }

    public class FixedHeightDownsampled
    {
        [JsonPropertyName("height")]
        public string height { get; set; }

        [JsonPropertyName("width")]
        public string width { get; set; }

        [JsonPropertyName("size")]
        public string size { get; set; }

        [JsonPropertyName("url")]
        public string url { get; set; }

        [JsonPropertyName("webp_size")]
        public string webp_size { get; set; }

        [JsonPropertyName("webp")]
        public string webp { get; set; }
    }

    public class FixedHeightSmall
    {
        [JsonPropertyName("height")]
        public string height { get; set; }

        [JsonPropertyName("width")]
        public string width { get; set; }

        [JsonPropertyName("size")]
        public string size { get; set; }

        [JsonPropertyName("url")]
        public string url { get; set; }

        [JsonPropertyName("mp4_size")]
        public string mp4_size { get; set; }

        [JsonPropertyName("mp4")]
        public string mp4 { get; set; }

        [JsonPropertyName("webp_size")]
        public string webp_size { get; set; }

        [JsonPropertyName("webp")]
        public string webp { get; set; }
    }

    public class FixedHeightSmallStill
    {
        [JsonPropertyName("height")]
        public string height { get; set; }

        [JsonPropertyName("width")]
        public string width { get; set; }

        [JsonPropertyName("size")]
        public string size { get; set; }

        [JsonPropertyName("url")]
        public string url { get; set; }
    }

    public class FixedHeightStill
    {
        [JsonPropertyName("height")]
        public string height { get; set; }

        [JsonPropertyName("width")]
        public string width { get; set; }

        [JsonPropertyName("size")]
        public string size { get; set; }

        [JsonPropertyName("url")]
        public string url { get; set; }
    }

    public class FixedWidth
    {
        [JsonPropertyName("height")]
        public string height { get; set; }

        [JsonPropertyName("width")]
        public string width { get; set; }

        [JsonPropertyName("size")]
        public string size { get; set; }

        [JsonPropertyName("url")]
        public string url { get; set; }

        [JsonPropertyName("mp4_size")]
        public string mp4_size { get; set; }

        [JsonPropertyName("mp4")]
        public string mp4 { get; set; }

        [JsonPropertyName("webp_size")]
        public string webp_size { get; set; }

        [JsonPropertyName("webp")]
        public string webp { get; set; }
    }

    public class FixedWidthDownsampled
    {
        [JsonPropertyName("height")]
        public string height { get; set; }

        [JsonPropertyName("width")]
        public string width { get; set; }

        [JsonPropertyName("size")]
        public string size { get; set; }

        [JsonPropertyName("url")]
        public string url { get; set; }

        [JsonPropertyName("webp_size")]
        public string webp_size { get; set; }

        [JsonPropertyName("webp")]
        public string webp { get; set; }
    }

    public class FixedWidthSmall
    {
        [JsonPropertyName("height")]
        public string height { get; set; }

        [JsonPropertyName("width")]
        public string width { get; set; }

        [JsonPropertyName("size")]
        public string size { get; set; }

        [JsonPropertyName("url")]
        public string url { get; set; }

        [JsonPropertyName("mp4_size")]
        public string mp4_size { get; set; }

        [JsonPropertyName("mp4")]
        public string mp4 { get; set; }

        [JsonPropertyName("webp_size")]
        public string webp_size { get; set; }

        [JsonPropertyName("webp")]
        public string webp { get; set; }
    }

    public class FixedWidthSmallStill
    {
        [JsonPropertyName("height")]
        public string height { get; set; }

        [JsonPropertyName("width")]
        public string width { get; set; }

        [JsonPropertyName("size")]
        public string size { get; set; }

        [JsonPropertyName("url")]
        public string url { get; set; }
    }

    public class FixedWidthStill
    {
        [JsonPropertyName("height")]
        public string height { get; set; }

        [JsonPropertyName("width")]
        public string width { get; set; }

        [JsonPropertyName("size")]
        public string size { get; set; }

        [JsonPropertyName("url")]
        public string url { get; set; }
    }

    public class Hd
    {
        [JsonPropertyName("height")]
        public string height { get; set; }

        [JsonPropertyName("width")]
        public string width { get; set; }

        [JsonPropertyName("mp4_size")]
        public string mp4_size { get; set; }

        [JsonPropertyName("mp4")]
        public string mp4 { get; set; }
    }

    public class Images
    {
        [JsonPropertyName("original")]
        public Original original { get; set; }

        [JsonPropertyName("downsized")]
        public Downsized downsized { get; set; }

        [JsonPropertyName("downsized_large")]
        public DownsizedLarge downsized_large { get; set; }

        [JsonPropertyName("downsized_medium")]
        public DownsizedMedium downsized_medium { get; set; }

        [JsonPropertyName("downsized_small")]
        public DownsizedSmall downsized_small { get; set; }

        [JsonPropertyName("downsized_still")]
        public DownsizedStill downsized_still { get; set; }

        [JsonPropertyName("fixed_height")]
        public FixedHeight fixed_height { get; set; }

        [JsonPropertyName("fixed_height_downsampled")]
        public FixedHeightDownsampled fixed_height_downsampled { get; set; }

        [JsonPropertyName("fixed_height_small")]
        public FixedHeightSmall fixed_height_small { get; set; }

        [JsonPropertyName("fixed_height_small_still")]
        public FixedHeightSmallStill fixed_height_small_still { get; set; }

        [JsonPropertyName("fixed_height_still")]
        public FixedHeightStill fixed_height_still { get; set; }

        [JsonPropertyName("fixed_width")]
        public FixedWidth fixed_width { get; set; }

        [JsonPropertyName("fixed_width_downsampled")]
        public FixedWidthDownsampled fixed_width_downsampled { get; set; }

        [JsonPropertyName("fixed_width_small")]
        public FixedWidthSmall fixed_width_small { get; set; }

        [JsonPropertyName("fixed_width_small_still")]
        public FixedWidthSmallStill fixed_width_small_still { get; set; }

        [JsonPropertyName("fixed_width_still")]
        public FixedWidthStill fixed_width_still { get; set; }

        [JsonPropertyName("looping")]
        public Looping looping { get; set; }

        [JsonPropertyName("original_still")]
        public OriginalStill original_still { get; set; }

        [JsonPropertyName("original_mp4")]
        public OriginalMp4 original_mp4 { get; set; }

        [JsonPropertyName("preview")]
        public Preview preview { get; set; }

        [JsonPropertyName("preview_gif")]
        public PreviewGif preview_gif { get; set; }

        [JsonPropertyName("preview_webp")]
        public PreviewWebp preview_webp { get; set; }

        [JsonPropertyName("hd")]
        public Hd hd { get; set; }

        [JsonPropertyName("480w_still")]
        public _480wStill _480w_still { get; set; }
    }

    public class Looping
    {
        [JsonPropertyName("mp4_size")]
        public string mp4_size { get; set; }

        [JsonPropertyName("mp4")]
        public string mp4 { get; set; }
    }

    public class Meta
    {
        [JsonPropertyName("status")]
        public int status { get; set; }

        [JsonPropertyName("msg")]
        public string msg { get; set; }

        [JsonPropertyName("response_id")]
        public string response_id { get; set; }
    }

    public class Onclick
    {
        [JsonPropertyName("url")]
        public string url { get; set; }
    }

    public class Onload
    {
        [JsonPropertyName("url")]
        public string url { get; set; }
    }

    public class Onsent
    {
        [JsonPropertyName("url")]
        public string url { get; set; }
    }

    public class Original
    {
        [JsonPropertyName("height")]
        public string height { get; set; }

        [JsonPropertyName("width")]
        public string width { get; set; }

        [JsonPropertyName("size")]
        public string size { get; set; }

        [JsonPropertyName("url")]
        public string url { get; set; }

        [JsonPropertyName("mp4_size")]
        public string mp4_size { get; set; }

        [JsonPropertyName("mp4")]
        public string mp4 { get; set; }

        [JsonPropertyName("webp_size")]
        public string webp_size { get; set; }

        [JsonPropertyName("webp")]
        public string webp { get; set; }

        [JsonPropertyName("frames")]
        public string frames { get; set; }

        [JsonPropertyName("hash")]
        public string hash { get; set; }
    }

    public class OriginalMp4
    {
        [JsonPropertyName("height")]
        public string height { get; set; }

        [JsonPropertyName("width")]
        public string width { get; set; }

        [JsonPropertyName("mp4_size")]
        public string mp4_size { get; set; }

        [JsonPropertyName("mp4")]
        public string mp4 { get; set; }
    }

    public class OriginalStill
    {
        [JsonPropertyName("height")]
        public string height { get; set; }

        [JsonPropertyName("width")]
        public string width { get; set; }

        [JsonPropertyName("size")]
        public string size { get; set; }

        [JsonPropertyName("url")]
        public string url { get; set; }
    }

    public class Pagination
    {
        [JsonPropertyName("total_count")]
        public int total_count { get; set; }

        [JsonPropertyName("count")]
        public int count { get; set; }

        [JsonPropertyName("offset")]
        public int offset { get; set; }
    }

    public class Preview
    {
        [JsonPropertyName("height")]
        public string height { get; set; }

        [JsonPropertyName("width")]
        public string width { get; set; }

        [JsonPropertyName("mp4_size")]
        public string mp4_size { get; set; }

        [JsonPropertyName("mp4")]
        public string mp4 { get; set; }
    }

    public class PreviewGif
    {
        [JsonPropertyName("height")]
        public string height { get; set; }

        [JsonPropertyName("width")]
        public string width { get; set; }

        [JsonPropertyName("size")]
        public string size { get; set; }

        [JsonPropertyName("url")]
        public string url { get; set; }
    }

    public class PreviewWebp
    {
        [JsonPropertyName("height")]
        public string height { get; set; }

        [JsonPropertyName("width")]
        public string width { get; set; }

        [JsonPropertyName("size")]
        public string size { get; set; }

        [JsonPropertyName("url")]
        public string url { get; set; }
    }

    public class User
    {
        [JsonPropertyName("avatar_url")]
        public string avatar_url { get; set; }

        [JsonPropertyName("banner_image")]
        public string banner_image { get; set; }

        [JsonPropertyName("banner_url")]
        public string banner_url { get; set; }

        [JsonPropertyName("profile_url")]
        public string profile_url { get; set; }

        [JsonPropertyName("username")]
        public string username { get; set; }

        [JsonPropertyName("display_name")]
        public string display_name { get; set; }

        [JsonPropertyName("description")]
        public string description { get; set; }

        [JsonPropertyName("instagram_url")]
        public string instagram_url { get; set; }

        [JsonPropertyName("website_url")]
        public string website_url { get; set; }

        [JsonPropertyName("is_verified")]
        public bool is_verified { get; set; }
    }


}
