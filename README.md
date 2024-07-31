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



KnapsackBarnchAndBound.cs

1.Class Program

![image](https://github.com/user-attachments/assets/e3568ff5-4fe4-410a-a9d3-ae44fdfbdd43)

Main Method: Đây là phương thức chính của chương trình. Trong đó:
Tạo một danh sách các vật phẩm với giá trị và trọng lượng tương ứng.
Xác định khả năng chứa của ba lô (ở đây là 50).
Gọi hàm KnapsackBranchAndBound để tính giá trị tối đa có thể chứa trong ba lô với danh sách vật phẩm đã cho.
In giá trị tối đa lên màn hình.

2.Class Item

![image](https://github.com/user-attachments/assets/4515cf51-83c5-4e94-b838-bcc8f570d74e)

Class Item: Định nghĩa một vật phẩm với ba thuộc tính:
Value (giá trị của vật phẩm).
Weight (trọng lượng của vật phẩm).
Ratio (tỉ lệ giá trị trên trọng lượng): Đây là thuộc tính chỉ đọc, tính bằng cách chia giá trị cho trọng lượng của vật phẩm. Tỉ lệ này được sử dụng để sắp xếp vật phẩm theo giá trị/khối lượng.

3.Class Node

![image](https://github.com/user-attachments/assets/c257679c-f9c6-417b-8db6-01c47d988c7a)

Class Node: Đại diện cho một nút trong cây phân nhánh với các thuộc tính:
Level: Mức độ của nút trong cây.
Profit: Giá trị lợi nhuận hiện tại.
Weight: Trọng lượng hiện tại.
Bound: Giá trị cận biên, ước tính lợi nhuận tối đa có thể đạt được từ nút này trở đi.

4.Method Bound

![image](https://github.com/user-attachments/assets/c6b2eac2-b165-4d4d-88c6-0c65a497efea)

Bound Method: Tính toán giá trị cận biên của một nút, dựa trên lợi nhuận hiện tại và trọng lượng hiện tại của nút đó.
Nếu trọng lượng hiện tại của nút lớn hơn hoặc bằng khả năng chứa của ba lô, trả về 0.
Tính toán lợi nhuận cận biên dựa trên các vật phẩm còn lại có thể thêm vào ba lô mà không vượt quá khả năng chứa.

5.Method KnapsackBranchAndBound

![image](https://github.com/user-attachments/assets/d371010b-4500-4457-b3c0-08fe425e2c9e)

KnapsackBranchAndBound Method: Phương thức chính để giải quyết bài toán ba lô bằng cách sử dụng thuật toán phân nhánh và cận biên.
Sắp xếp danh sách vật phẩm theo tỉ lệ giá trị trên trọng lượng giảm dần.
Sử dụng hàng đợi (Queue) để duyệt cây phân nhánh.
Tại mỗi nút, tạo ra các nút con tương ứng với việc bao gồm và không bao gồm vật phẩm ở mức độ tiếp theo.
Tính toán giá trị cận biên cho các nút con và chỉ thêm chúng vào hàng đợi nếu giá trị cận biên lớn hơn giá trị lợi nhuận tối đa hiện tại.
Trả về giá trị lợi nhuận tối đa tìm được.

Tổng kết
Thuật toán Branch and Bound hiệu quả hơn thuật toán tham lam thông thường vì nó xem xét nhiều khả năng hơn, không chỉ dừng lại ở lựa chọn tốt nhất hiện tại mà còn xem xét các lựa chọn trong tương lai để đảm bảo giá trị tối ưu. Thuật toán này phức tạp hơn nhưng có thể tìm ra giải pháp tốt hơn cho bài toán ba lô.






