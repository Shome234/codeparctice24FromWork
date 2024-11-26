```ts
import jwt from "jsonwebtoken";
import {cookies} from "next/headers";
async function generateToken(user){
const {_id,email,username,role}=user;
const tokenData={id:_id,username:username,email:email,role:role};
const refreshData={id:_id,role:role};
const accessToken=jwt.sign(tokenData,process.env.ACCESS_SECRET_KEY,{expiresIn:"30m"});
const refreshToken=jwt.sign(refreshData,process.env.REFRESH_SECRET_KEY,{expiresIn:"7d"});
const getCookies=cookies();
getCookies.set("access_token",accessToken);
getCookies.set("refresh_token",refreshToken);
}

async function refreshAccess(refreshToken){
const decodedToken=jwt.verify(refreshToken,process.env.REFRESH_SECRET_KEY);
//strategy 1
await dbConnect();
const userInfo=await User.find(decodedtoken.id);
if(userInfo){
const {_id,email,username,role}=userInfo;
const tokenData={id:_id,username:username,email:email,role:role};
const accessToken=jwt.sign(tokenData,process.env.ACCESS_SECRET_KEY,{expiresIn:"30m"}); 
const getCookies=cookies();
getCookies.set("access_token",accessToken);
}
}
```

```ts
export async function POST(req:Request){
	const {}=await req.json();
  const cook=req.cookies.get();
	const {data:user}=useSession();
	if(!title) throw new Error("Please provide an title to continue");
	const catObj=new Category(title:title,createdBy:user._id);
	const newcategory=await Category.create(catObj);
	return Response.json({success:true,status:200,data:Category.findById(newCategory._id)};
}
```
