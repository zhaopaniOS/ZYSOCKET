﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.34209
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsgPack.Serialization.GeneratedSerializers.MapBased {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.6.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class MsgPack_Serialization_TupleAbstractTypeSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.TupleAbstractType> {
        
        private MsgPack.Serialization.MessagePackSerializer<string> _serializer0;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Tuple<MsgPack.Serialization.AbstractFileSystemEntry, MsgPack.Serialization.IFileSystemEntry, MsgPack.Serialization.AbstractFileSystemEntry, MsgPack.Serialization.IFileSystemEntry>> _serializer1;
        
        public MsgPack_Serialization_TupleAbstractTypeSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            MsgPack.Serialization.PolymorphismSchema[] tupleItemsSchema0 = default(MsgPack.Serialization.PolymorphismSchema[]);
            tupleItemsSchema0 = new MsgPack.Serialization.PolymorphismSchema[4];
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema0 = default(MsgPack.Serialization.PolymorphismSchema);
            System.Collections.Generic.Dictionary<string, System.Type> tupleItemSchemaTypeMap0 = default(System.Collections.Generic.Dictionary<string, System.Type>);
            tupleItemSchemaTypeMap0 = new System.Collections.Generic.Dictionary<string, System.Type>(1);
            tupleItemSchemaTypeMap0.Add("1", typeof(MsgPack.Serialization.FileEntry));
            tupleItemSchema0 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.AbstractFileSystemEntry), tupleItemSchemaTypeMap0);
            tupleItemsSchema0[0] = tupleItemSchema0;
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema1 = default(MsgPack.Serialization.PolymorphismSchema);
            System.Collections.Generic.Dictionary<string, System.Type> tupleItemSchema1TypeMap0 = default(System.Collections.Generic.Dictionary<string, System.Type>);
            tupleItemSchema1TypeMap0 = new System.Collections.Generic.Dictionary<string, System.Type>(1);
            tupleItemSchema1TypeMap0.Add("1", typeof(MsgPack.Serialization.FileEntry));
            tupleItemSchema1 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.IFileSystemEntry), tupleItemSchema1TypeMap0);
            tupleItemsSchema0[1] = tupleItemSchema1;
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema2 = default(MsgPack.Serialization.PolymorphismSchema);
            tupleItemSchema2 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.AbstractFileSystemEntry));
            tupleItemsSchema0[2] = tupleItemSchema2;
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema3 = default(MsgPack.Serialization.PolymorphismSchema);
            tupleItemSchema3 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.IFileSystemEntry));
            tupleItemsSchema0[3] = tupleItemSchema3;
            schema0 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicTuple(typeof(System.Tuple<MsgPack.Serialization.AbstractFileSystemEntry, MsgPack.Serialization.IFileSystemEntry, MsgPack.Serialization.AbstractFileSystemEntry, MsgPack.Serialization.IFileSystemEntry>), tupleItemsSchema0);
            this._serializer0 = context.GetSerializer<string>(schema0);
            MsgPack.Serialization.PolymorphismSchema schema1 = default(MsgPack.Serialization.PolymorphismSchema);
            MsgPack.Serialization.PolymorphismSchema[] tupleItemsSchema1 = default(MsgPack.Serialization.PolymorphismSchema[]);
            tupleItemsSchema1 = new MsgPack.Serialization.PolymorphismSchema[4];
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema4 = default(MsgPack.Serialization.PolymorphismSchema);
            System.Collections.Generic.Dictionary<string, System.Type> tupleItemSchema4TypeMap0 = default(System.Collections.Generic.Dictionary<string, System.Type>);
            tupleItemSchema4TypeMap0 = new System.Collections.Generic.Dictionary<string, System.Type>(1);
            tupleItemSchema4TypeMap0.Add("1", typeof(MsgPack.Serialization.FileEntry));
            tupleItemSchema4 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.AbstractFileSystemEntry), tupleItemSchema4TypeMap0);
            tupleItemsSchema1[0] = tupleItemSchema4;
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema5 = default(MsgPack.Serialization.PolymorphismSchema);
            System.Collections.Generic.Dictionary<string, System.Type> tupleItemSchema5TypeMap0 = default(System.Collections.Generic.Dictionary<string, System.Type>);
            tupleItemSchema5TypeMap0 = new System.Collections.Generic.Dictionary<string, System.Type>(1);
            tupleItemSchema5TypeMap0.Add("1", typeof(MsgPack.Serialization.FileEntry));
            tupleItemSchema5 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.IFileSystemEntry), tupleItemSchema5TypeMap0);
            tupleItemsSchema1[1] = tupleItemSchema5;
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema6 = default(MsgPack.Serialization.PolymorphismSchema);
            tupleItemSchema6 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.AbstractFileSystemEntry));
            tupleItemsSchema1[2] = tupleItemSchema6;
            MsgPack.Serialization.PolymorphismSchema tupleItemSchema7 = default(MsgPack.Serialization.PolymorphismSchema);
            tupleItemSchema7 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.IFileSystemEntry));
            tupleItemsSchema1[3] = tupleItemSchema7;
            schema1 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicTuple(typeof(System.Tuple<MsgPack.Serialization.AbstractFileSystemEntry, MsgPack.Serialization.IFileSystemEntry, MsgPack.Serialization.AbstractFileSystemEntry, MsgPack.Serialization.IFileSystemEntry>), tupleItemsSchema1);
            this._serializer1 = context.GetSerializer<System.Tuple<MsgPack.Serialization.AbstractFileSystemEntry, MsgPack.Serialization.IFileSystemEntry, MsgPack.Serialization.AbstractFileSystemEntry, MsgPack.Serialization.IFileSystemEntry>>(schema1);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.TupleAbstractType objectTree) {
            packer.PackMapHeader(1);
            this._serializer0.PackTo(packer, "Value");
            this._serializer1.PackTo(packer, objectTree.Value);
        }
        
        protected internal override MsgPack.Serialization.TupleAbstractType UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.TupleAbstractType result = default(MsgPack.Serialization.TupleAbstractType);
            result = new MsgPack.Serialization.TupleAbstractType();
            if (unpacker.IsArrayHeader) {
                int unpacked = default(int);
                int itemsCount = default(int);
                itemsCount = MsgPack.Serialization.UnpackHelpers.GetItemsCount(unpacker);
                System.Tuple<MsgPack.Serialization.AbstractFileSystemEntry, MsgPack.Serialization.IFileSystemEntry, MsgPack.Serialization.AbstractFileSystemEntry, MsgPack.Serialization.IFileSystemEntry> nullable = default(System.Tuple<MsgPack.Serialization.AbstractFileSystemEntry, MsgPack.Serialization.IFileSystemEntry, MsgPack.Serialization.AbstractFileSystemEntry, MsgPack.Serialization.IFileSystemEntry>);
                if ((unpacked < itemsCount)) {
                    if ((unpacker.Read() == false)) {
                        throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(0);
                    }
                    if (((unpacker.IsArrayHeader == false) 
                                && (unpacker.IsMapHeader == false))) {
                        nullable = this._serializer1.UnpackFrom(unpacker);
                    }
                    else {
                        MsgPack.Unpacker disposable = default(MsgPack.Unpacker);
                        disposable = unpacker.ReadSubtree();
                        try {
                            nullable = this._serializer1.UnpackFrom(disposable);
                        }
                        finally {
                            if (((disposable == null) 
                                        == false)) {
                                disposable.Dispose();
                            }
                        }
                    }
                }
                if (((nullable == null) 
                            == false)) {
                    result.Value = nullable;
                }
                unpacked = (unpacked + 1);
            }
            else {
                int itemsCount0 = default(int);
                itemsCount0 = MsgPack.Serialization.UnpackHelpers.GetItemsCount(unpacker);
                for (int i = 0; (i < itemsCount0); i = (i + 1)) {
                    string key = default(string);
                    string nullable0 = default(string);
                    nullable0 = MsgPack.Serialization.UnpackHelpers.UnpackStringValue(unpacker, typeof(MsgPack.Serialization.TupleAbstractType), "MemberName");
                    if (((nullable0 == null) 
                                == false)) {
                        key = nullable0;
                    }
                    else {
                        throw MsgPack.Serialization.SerializationExceptions.NewNullIsProhibited("MemberName");
                    }
                    if ((key == "Value")) {
                        System.Tuple<MsgPack.Serialization.AbstractFileSystemEntry, MsgPack.Serialization.IFileSystemEntry, MsgPack.Serialization.AbstractFileSystemEntry, MsgPack.Serialization.IFileSystemEntry> nullable1 = default(System.Tuple<MsgPack.Serialization.AbstractFileSystemEntry, MsgPack.Serialization.IFileSystemEntry, MsgPack.Serialization.AbstractFileSystemEntry, MsgPack.Serialization.IFileSystemEntry>);
                        if ((unpacker.Read() == false)) {
                            throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(i);
                        }
                        if (((unpacker.IsArrayHeader == false) 
                                    && (unpacker.IsMapHeader == false))) {
                            nullable1 = this._serializer1.UnpackFrom(unpacker);
                        }
                        else {
                            MsgPack.Unpacker disposable0 = default(MsgPack.Unpacker);
                            disposable0 = unpacker.ReadSubtree();
                            try {
                                nullable1 = this._serializer1.UnpackFrom(disposable0);
                            }
                            finally {
                                if (((disposable0 == null) 
                                            == false)) {
                                    disposable0.Dispose();
                                }
                            }
                        }
                        if (((nullable1 == null) 
                                    == false)) {
                            result.Value = nullable1;
                        }
                    }
                    else {
                        unpacker.Skip();
                    }
                }
            }
            return result;
        }
        
        private static T @__Conditional<T>(bool condition, T whenTrue, T whenFalse)
         {
            if (condition) {
                return whenTrue;
            }
            else {
                return whenFalse;
            }
        }
    }
}