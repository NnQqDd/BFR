# BFR

BFR pharmacy management

# ngoc test1
-label ở từng 1 groupbox 1 sẽ hiển thị tương ứng lần lượt là 
-lbSLKhachHang: hiển thị số lượng khách hàng
-lbSlSP: hiển thị tổng số lượng sản phẩm
-lbTongdonhang: hiển thị tổng số lượng đơn hàng
-lbslhangsaphet:hiển thị số lượng hàng sắp hết
-dataGridView1:hiển thị top khách hàng có tổng tiền mua cao nhất (sắp xếp từ cao đến thấp theo trường TongTienDaMua
có các trường:
+ID(MaKhach)
+Tên khách hàng(TenKhach)
+Địa chỉ(DiaChi)
+Điện thoại(DienThoai)
+Tổng tiền(SUM(TongTien))
-dataGridView2:hiển thị khách hàng được sắp xếp theo thời gian bán gần nhất và (tham khảo) dùng Hoadonban.ngayban >= DATEADD(MONTH, -1, GETDATE()) để lọc khách hàng mới chưa mua gì(có thể thay bằng bảng khác)
+ID(MaKhach)
+Tên khách hàng(TenKhach)
+Địa chỉ(DiaChi)
+Điện thoại(DienThoai)
