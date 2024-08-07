using System.Collections.Generic;
using Unity.Sentis;

namespace Doji.AI.Utils {

    internal static class TensorShapeHelper {

        public static TensorShape ConcatShape(Tensor[] tensors, int axis) {
            TensorShape output = tensors[0].shape;

            for (int i = 1; i < tensors.Length; ++i) {
                TensorShape shape = tensors[i].shape;
                output = output.Concat(shape, axis);
            }

            return output;
        }

        public static TensorShape ConcatShape(List<Tensor> tensors, int axis) {
            TensorShape output = tensors[0].shape;

            for (int i = 1; i < tensors.Count; ++i) {
                TensorShape shape = tensors[i].shape;
                output = output.Concat(shape, axis);
            }

            return output;
        }

        public static TensorShape ConcatShape(Tensor tensor1, Tensor tensor2, int axis) {
            return tensor1.shape.Concat(tensor2.shape, axis);
        }

        public static TensorShape BroadcastShape(Tensor a, Tensor b) {
            return a.shape.Broadcast(b.shape);
        }
    }
}