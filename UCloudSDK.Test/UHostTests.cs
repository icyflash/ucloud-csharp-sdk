﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UCloudSDK;
using UCloudSDK.Test;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UCloudSDK.Models;

namespace UCloudSDK.Tests
{
    [TestClass()]
    public class UHostTests
    {
        UHost uhost = new UHost(Config.PublicKey, Config.PrivateKey);

        /// <summary>
        /// 镜像名称
        /// <para>
        /// 通过DescribeImage得到
        /// </para>
        /// </summary>
        private string uimageid = "uimage-34emui";

        /// <summary>
        /// 云硬盘ID，通过UDisk.DescribeUDisk获得
        /// </summary>
        private string uDiskId = "u0TD9595816accc04fc3a7cf34791a2c46dd";

        [TestMethod()]
        public void AttachUDiskTest()
        {
            var entity = new AttachUDiskRequest(Config.region, Config.UhostId,uDiskId);
            var response = uhost.AttachUDisk(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void CreateCustomImageTest()
        {
            var entity = new CreateCustomImageRequest(Config.region, Config.UhostId,"testimage");
            var response = uhost.CreateCustomImage(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void CreateUHostInstanceTest()
        {
            var entity = new CreateUHostInstanceRequest(Config.region, uimageid, "Password");
            //设置其它参数
            entity.CPU = 2;
            entity.Memory = 2048;
            entity.DiskSpace = 10;
            entity.Password = "Ucloud123";
            entity.Name = "UCloudExample00";
            //entity.ChargeType = "Month";
            entity.ChargeType = UHostChargeType.Month.ToString();
            entity.Quantity = 1;
            //请求API，返回类型为CreateUHostInstanceResponse
            var response = uhost.CreateUHostInstance(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void CreateUHostInstanceSnapshotTest()
        {
            var entity = new CreateUHostInstanceSnapshotRequest(Config.region, Config.UhostId);
            var response = uhost.CreateUHostInstanceSnapshot(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void DescribeImageTest()
        {
            var entity = new DescribeImageRequest(Config.region)
            {
                ImageType = "Base",
                OsType = OsType.Windows.ToString()
            };

            var response = uhost.DescribeImage(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void DescribeUHostInstanceTest()
        {
            var entity = new DescribeUHostInstanceRequest(Config.region);
            var response = uhost.DescribeUHostInstance(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void DescribeUHostInstanceSnapshotTest()
        {
            var entity = new DescribeUHostInstanceSnapshotRequest(Config.region,Config.UhostId);
            var response = uhost.DescribeUHostInstanceSnapshot(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void DetachUDiskTest()
        {
            var entity = new DetachUDiskRequest(Config.region, Config.UhostId, uDiskId);
            var response = uhost.DetachUDisk(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void GetUHostInstancePriceTest()
        {
            var entity = new GetUHostInstancePriceRequest(Config.region, uimageid, 2, 4096, 1);
            var response = uhost.GetUHostInstancePrice(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void GetUHostInstanceVncInfoTest()
        {
            var entity = new GetUHostInstanceVncInfoRequest(Config.region,Config.UhostId);
            var response = uhost.GetUHostInstanceVncInfo(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void ModifyUHostInstanceNameTest()
        {
            var entity = new ModifyUHostInstanceNameRequest(Config.region, Config.UhostId,"icyhost");
            var response = uhost.ModifyUHostInstanceName(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void ModifyUHostInstanceRemarkTest()
        {
            var entity = new ModifyUHostInstanceRemarkRequest(Config.region, Config.UhostId,"Icy主机");
            var response = uhost.ModifyUHostInstanceRemark(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void ModifyUHostInstanceTagTest()
        {
            var entity = new ModifyUHostInstanceTagRequest(Config.region, Config.UhostId, "Icy");
            var response = uhost.ModifyUHostInstanceTag(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void RebootUHostInstanceTest()
        {
            var entity = new RebootUHostInstanceRequest(Config.region, Config.UhostId);
            var response = uhost.RebootUHostInstance(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void ReinstallUHostInstanceTest()
        {
            //先关闭UHost再进行些测试
            var entity = new ReinstallUHostInstanceRequest(Config.region, Config.UhostId);
            entity.Password = "Ucloud123";
            var response = uhost.ReinstallUHostInstance(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void ResetUHostInstancePasswordTest()
        {
            //先关闭UHost再进行些测试
            var entity = new ResetUHostInstancePasswordRequest(Config.region, Config.UhostId);
            entity.Password = "Ucloud321";
            var response = uhost.ResetUHostInstancePassword(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void ResizeUHostInstanceTest()
        {
            var entity = new ResizeUHostInstanceRequest(Config.region, Config.UhostId);
            var response = uhost.ResizeUHostInstance(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void StartUHostInstanceTest()
        {
            var entity = new StartUHostInstanceRequest(Config.region, Config.UhostId);
            var response = uhost.StartUHostInstance(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void StopUHostInstanceTest()
        {
            var entity = new StopUHostInstanceRequest(Config.region, Config.UhostId);
            var response = uhost.StopUHostInstance(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void TerminateCustomImageTest()
        {
            //镜像ID从创建镜像的返回值获得
            var uimage = "uimage-11al2d";
            var entity = new TerminateCustomImageRequest(Config.region, uimage);
            var response = uhost.TerminateCustomImage(entity);
            Assert.AreEqual(response.RetCode, 0);
        }

        [TestMethod()]
        public void TerminateUHostInstanceTest()
        {
            var entity = new TerminateUHostInstanceRequest(Config.region, Config.UhostId);
            var response = uhost.TerminateUHostInstance(entity);
            Assert.AreEqual(response.RetCode, 0);
        }
    }
}
