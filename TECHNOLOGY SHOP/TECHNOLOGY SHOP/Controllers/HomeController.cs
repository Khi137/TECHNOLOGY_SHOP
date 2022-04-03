﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TECHNOLOGY_SHOP.Models;

namespace TECHNOLOGY_SHOP.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        MyDataDataContext data = new MyDataDataContext();
        public ActionResult Index()
        {
            var allSanPham1 = from sanpham in data.tb_SanPhams where sanpham.idLoaiSP == 10 & sanpham.trangThai == true select sanpham;
            ViewBag.lst1 = allSanPham1;
            var allSanPham2 = from sanpham in data.tb_SanPhams where sanpham.idLoaiSP == 25 & sanpham.trangThai == true select sanpham;
            ViewBag.lst2 = allSanPham2;
            var allSanPham3 = from sanpham in data.tb_SanPhams where sanpham.idLoaiSP == 26 & sanpham.trangThai == true select sanpham;
            ViewBag.lst3 = allSanPham3;
            var loaisanpham = from loai in data.tb_LoaiSanPhams select loai;
            ViewBag.loaisanphamAll = loaisanpham;
            var hangsanpham = from hang in data.tb_HangSanPhams select hang;
            ViewBag.hangsanphamAll = hangsanpham;
            return View(allSanPham1);
        }

        public ActionResult SanPham(int id)
        {
            var sanpham = from sp in data.tb_SanPhams where sp.idLoaiSP==id select sp;
            ViewBag.loaisanphamAll = sanpham;
            return View(sanpham);
        }

        public ActionResult SanPhamByHang(int id)
        {
            var sanpham = from sp in data.tb_SanPhams where sp.idHang == id select sp;
            ViewBag.loaisanphamAll = sanpham;

            ViewBag.loaisanphamAll = sanpham;
            return View(sanpham);
        }
    }
}