# Responsive WebGL Template by BillTheDev

Một template WebGL Unity cung cấp trải nghiệm toàn màn hình và khả năng đáp ứng (responsive) cho trình duyệt.

## Tính năng

*   **Thiết kế Đáp ứng (Responsive):** Tự động điều chỉnh theo kích thước cửa sổ trình duyệt khác nhau, đảm bảo trò chơi WebGL của bạn hiển thị tốt trên nhiều loại màn hình.
*   **Hiển thị Toàn Màn Hình:** Template được thiết kế để trò chơi WebGL của bạn chiếm toàn bộ cửa sổ trình duyệt mà không có thanh cuộn.
*   **Thanh Tiến Trình Tải Cơ Bản:** Bao gồm một thanh tiến trình tải đơn giản để cung cấp phản hồi trực quan trong quá trình tải game.
*   **Dễ Sử Dụng:** Chỉ cần chọn template "ResponsiveWebGL" trong cài đặt build WebGL của Unity.

## Cài đặt (qua .unitypackage - Khuyến nghị)

1.  **Tải file .unitypackage:** Truy cập trang [Releases](Link-to-your-GitHub-Releases-page) của repository này và tải file `ResponsiveWebGLTemplate.unitypackage` phiên bản mới nhất.
2.  **Import vào project Unity:** Trong project Unity của bạn, chọn `Assets > Import Package > Custom Package...` và chọn file `ResponsiveWebGLTemplate.unitypackage` vừa tải xuống.
3.  **Tìm template:** Sau khi import, các file template sẽ nằm trong `Assets/WebGLTemplates/ResponsiveWebGL/`.

## Cài đặt (qua Git URL - Dành cho người dùng Package Manager)

1.  **Mở Package Manager:** Trong project Unity của bạn, mở Package Manager (`Window > Package Manager`).
2.  **Thêm package từ Git URL:** Nhấp vào nút "+" ở góc trên bên trái và chọn "Add package from git URL...".
3.  **Nhập Git URL:** Dán URL sau vào ô: `https://github.com/truongbill003/FullWindowWebGLTemplate.git` **(Vui lòng kiểm tra lại URL này có đúng cho template ResponsiveWebGL của bạn không)**
4.  **Chọn template trong Build Settings:** Mở `File > Build Settings`, chọn nền tảng WebGL và nhấp vào "Player Settings...". Trong cửa sổ Inspector, dưới "Publishing Settings", tìm tùy chọn "WebGL Template" và chọn "ResponsiveWebGL".

## Sử dụng

1.  **Chọn template trong Build Settings:** Trong project Unity, vào `File > Build Settings...`, chọn nền tảng WebGL, và nhấp "Player Settings...". Dưới "Publishing Settings", tìm tùy chọn "WebGL Template" và chọn "ResponsiveWebGL".
2.  **Build project WebGL:** Build project Unity của bạn cho WebGL như bình thường (`File > Build Settings... > Build`). Bản build cuối cùng sẽ sử dụng template ResponsiveWebGL.

## Tùy chỉnh

*   **Kiểu dáng (Styling):** Chỉnh sửa file `Assets/WebGLTemplates/ResponsiveWebGL/TemplateData/style.css` để tùy chỉnh giao diện trực quan, bao gồm màu nền, font chữ và kiểu dáng thanh tiến trình tải.
*   **Thanh Tiến Trình Tải:** Thay đổi hành vi và hình thức của thanh tiến trình tải bằng cách chỉnh sửa file `Assets/WebGLTemplates/ResponsiveWebGL/TemplateData/index.html`.
*   **Favicon:** Thay thế `Assets/WebGLTemplates/ResponsiveWebGL/TemplateData/favicon.ico` bằng favicon của riêng bạn để cá nhân hóa biểu tượng tab trình duyệt.

## Cấu trúc thư mục sau khi Import