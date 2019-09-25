namespace Nager.AmazonProductAdvertising
{
    /// <summary>
    /// Amazon Authentication
    /// </summary>
    public class AmazonAuthentication
    {
        /// <summary>
        /// Amazon AccessKey
        /// </summary>
        public string AccessKey { get; set; }

        /// <summary>
        /// Amazon SecretKey
        /// </summary>
        public string SecretKey { get; set; }

        /// <summary>
        /// AmazonAuthentication
        /// </summary>
        public AmazonAuthentication()
        { }

        /// <summary>
        /// AmazonAuthentication
        /// </summary>
        /// <param name="accessKey"></param>
        /// <param name="secretKey"></param>
        public AmazonAuthentication(string accessKey, string secretKey)
        {
            this.AccessKey = accessKey;
            this.SecretKey = secretKey;
        }
    }
}
