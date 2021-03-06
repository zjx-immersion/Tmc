﻿namespace Tmc
{
    internal class ErrorMessages
    {
        public const string EnumFailedVersion = "Collection was modified after the enumerator was instantiated.";
        public const string ExternalHashedLinkedListNode = "The HashedLinkedList node does not belong to current HashedLinkedList.";
        public const string HashedLinkedListEmpty = "The HashedLinkedList is empty.";
        public const string HashedLinkedListNodeIsAttached = "The HashedLinkedList node already belongs to a HashedLinkedList.";
        public const string IndexOutOfRange = "Index {0} is out of range.";
        public const string InsufficientSpace = "Insufficient space in the target location to copy the information.";
        public const string InvalidArrayType = "Target array type is not compatible with the type of items in the collection.";
        public const string MultiRank = "Multi dimension array is not supported on this operation.";
        public const string NonZeroLowerBound = "The lower bound of target array must be zero.";
    }
}
