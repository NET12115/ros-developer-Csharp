/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

using Newtonsoft.Json;

using RosSharp.RosBridgeClient.MessageTypes.Geometry;

namespace RosSharp.RosBridgeClient.MessageTypes.Shape
{
    public class Mesh : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "shape_msgs/Mesh";

        //  Definition of a mesh
        //  list of triangles; the index values refer to positions in vertices[]
        public MeshTriangle[] triangles;
        //  the actual vertices that make up the mesh
        public Point[] vertices;

        public Mesh()
        {
            this.triangles = new MeshTriangle[0];
            this.vertices = new Point[0];
        }

        public Mesh(MeshTriangle[] triangles, Point[] vertices)
        {
            this.triangles = triangles;
            this.vertices = vertices;
        }
    }
}
