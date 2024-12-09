
alert("Xin chào tôi là Đoàn")

    var XoaDanhMuc = function (idDanhMuc) {
            if (confirm("Bạn  chắc chắn muốn xóa danh mục có ID= " + idDanhMuc+" hay không?") == true) {
        location.href = "/Home/XoaDanhMuc?idDanhMuc=" + idDanhMuc
    }
    
