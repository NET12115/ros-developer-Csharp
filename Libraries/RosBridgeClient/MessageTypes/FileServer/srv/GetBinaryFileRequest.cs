/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

namespace RosSharp.RosBridgeClient.MessageTypes.FileServer
{
    public class GetBinaryFileRequest : Message
    {
        public const string RosMessageName = "file_server/GetBinaryFile";

        public string name { get; set; }

        public GetBinaryFileRequest()
        {
            this.name = "";
        }

        public GetBinaryFileRequest(string name)
        {
            this.name = name;
        }
    }
}
