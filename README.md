# PTTKTT_buoi4
greedynapsack.cs
1.Class Program
![image](https://github.com/user-attachments/assets/d47e82ea-bf07-4298-b74f-ca1a7b25a56b)
Main Method: Đây là phương thức chính của chương trình. Trong đó:
Tạo một danh sách các vật phẩm với giá trị và trọng lượng tương ứng.
Xác định khả năng chứa của ba lô (ở đây là 50).
Gọi hàm GreedyKnapsack để tính giá trị tối đa có thể chứa trong ba lô với danh sách vật phẩm đã cho.
In giá trị tối đa lên màn hình.
2.Class Item
![image](https://github.com/user-attachments/assets/29ba4f04-4414-40da-beb6-aa50e12985a1)
Class Item: Định nghĩa một vật phẩm với hai thuộc tính:
Value (giá trị của vật phẩm).
Weight (trọng lượng của vật phẩm).
Ratio (tỉ lệ giá trị trên trọng lượng): Đây là thuộc tính chỉ đọc, tính bằng cách chia giá trị cho trọng lượng của vật phẩm. Tỉ lệ này được sử dụng để sắp xếp vật phẩm theo giá trị/khối lượng.
3.Phương thức GreedyKnapsack
![image](https://github.com/user-attachments/assets/4fca8844-4254-49f8-a48b-c3ed53aae007)

GreedyKnapsack Method: Đây là phương thức chính để giải quyết bài toán ba lô theo cách tham lam.
Sắp xếp danh sách vật phẩm theo tỉ lệ giá trị trên trọng lượng giảm dần.
Khởi tạo tổng giá trị và trọng lượng hiện tại là 0.
Duyệt qua từng vật phẩm trong danh sách đã sắp xếp:
Nếu thêm vật phẩm vào ba lô mà không vượt quá khả năng chứa, thêm trọng lượng và giá trị của vật phẩm vào tổng.
Nếu thêm vật phẩm vào ba lô vượt quá khả năng chứa, chỉ thêm một phần của vật phẩm dựa trên trọng lượng còn lại có thể chứa trong ba lô, sau đó dừng lại.
Trả về tổng giá trị có thể chứa trong ba lô.

Chức năng của mã
Mã này nhằm giải quyết bài toán "Knapsack Problem" bằng thuật toán tham lam, một phương pháp tiếp cận đơn giản nhưng hiệu quả trong nhiều trường hợp thực tế. Bằng cách sắp xếp các vật phẩm theo tỉ lệ giá trị trên trọng lượng giảm dần, thuật toán tham lam sẽ chọn các vật phẩm có giá trị cao nhất cho mỗi đơn vị trọng lượng trước tiên, nhằm tối ưu hóa giá trị tổng trong giới hạn trọng lượng cho phép của ba lô.

Kết luận
Chương trình này minh họa cách tiếp cận tham lam để giải quyết bài toán ba lô một cách hiệu quả và dễ hiểu. 
