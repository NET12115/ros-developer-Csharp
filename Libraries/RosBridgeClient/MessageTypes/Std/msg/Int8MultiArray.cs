/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

using Newtonsoft.Json;

namespace RosSharp.RosBridgeClient.MessageTypes.Std
{
    public class Int8MultiArray : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "std_msgs/Int8MultiArray";

        //  Please look at the MultiArrayLayout message definition for
        //  documentation on all multiarrays.
        public MultiArrayLayout layout;
        //  specification of data layout
        public sbyte[] data;
        //  array of data

        public Int8MultiArray()
        {
            this.layout = new MultiArrayLayout();
            this.data = new sbyte[0];
        }

        public Int8MultiArray(MultiArrayLayout layout, sbyte[] data)
        {
            this.layout = layout;
            this.data = data;
        }
    }
}
