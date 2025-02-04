﻿using System;
using Neo;
using Neo.SmartContract.Framework;
using Neo.SmartContract.Framework.Native;
using Neo.SmartContract.Framework.Services;

namespace CommitteeInfoContract
{
    partial class CommitteeInfoContract
    {
        #region Admin


#warning 检查此处的 Admin 地址是否为最新地址
        //[InitialValue("NPS3U9PduobRCai5ZUdK2P3Y8RjwzMVfSg", Neo.SmartContract.ContractParameterType.Hash160)]
        //static readonly UInt160 superAdmin = default;
        const string AdminKey = nameof(superAdmin);
        #region MainNet

        [InitialValue("NdSbtzKb9uR9waVGfPq3JqiNyMg59Umpxb", Neo.SmartContract.ContractParameterType.Hash160)]
        static readonly UInt160 superAdmin = default;
        #endregion

        #region TestNet

        //[InitialValue("NWPrismdD6mEmyGSxJNATLaMV4uNr6C8Ej", Neo.SmartContract.ContractParameterType.Hash160)]
        //static readonly UInt160 superAdmin = default;

        #endregion

        // When this contract address is included in the transaction signature,
        // this method will be triggered as a VerificationTrigger to verify that the signature is correct.
        // For example, this method needs to be called when withdrawing token from the contract.
        public static bool Verify() => Runtime.CheckWitness(GetAdmin());
        /// <summary>
        /// 获取合约管理员
        /// </summary>
        /// <returns></returns>
        public static UInt160 GetAdmin()
        {
            var admin = StorageGet(AdminKey);
            return admin?.Length == 20 ? (UInt160)admin : superAdmin;
        }

        /// <summary>
        /// 设置合约管理员
        /// </summary>
        /// <param name="admin"></param>
        /// <returns></returns>
        public static bool SetAdmin(UInt160 admin)
        {
            Assert(Runtime.CheckWitness(GetAdmin()), "Forbidden");
            StoragePut(AdminKey, admin);
            return true;
        }



        #endregion


        #region Upgrade

        /// <summary>
        /// 升级
        /// </summary>
        /// <param name="nefFile"></param>
        /// <param name="manifest"></param>
        /// <param name="data"></param>
        public static void Update(ByteString nefFile, string manifest, object data)
        {
            if (!Verify()) throw new Exception("No authorization.");
            ContractManagement.Update(nefFile, manifest, data);
        }


        #endregion
    }
}
