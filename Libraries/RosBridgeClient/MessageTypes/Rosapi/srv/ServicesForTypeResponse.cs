/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */


namespace RosSharp.RosBridgeClient.MessageTypes.Rosapi
{
    public class ServicesForTypeResponse : Message
    {
        public const string RosMessageName = "rosapi/ServicesForType";

        public string[] services { get; set; }

        public ServicesForTypeResponse()
        {
            this.services = new string[0];
        }

        public ServicesForTypeResponse(string[] services)
        {
            this.services = services;
        }
    }
}
